using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EdgeJs;

namespace NeuralTrade
{
    public class NetworkHandler
    {
        Func<object, Task<object>> networkQuery;

        public NetworkHandler()
        {
            networkQuery = Edge.Func(@"
                var brain = require('brain');
                var _ = require('underscore');

                var net = new brain.NeuralNetwork({
                        hiddenLayers: [2, 2]
                    });
                                

                return function (query, cb) {
                    var logging = function (m1) {
                        query.loggingFunction(m1);
                    };
                    if (query.mode == 'train')
                    {
                        query.trainSettings.callback = logging;
                        var output = net.train(query.data, query.trainSettings); // , query.trainSettings
                        cb(null, output);
                    }
                    if (query.mode == 'run')
                    {
                        var output = net.run(query.data);
                        cb(null, output);
                    }
                };
            ");
        }



        public async Task<TrainOutput> train(ICollection<TrainingItem> data)
        {
            TrainQuery query = new TrainQuery("train", data);
            var result = (IDictionary<string, object>)(await networkQuery(query));
            return new TrainOutput(result); ;
        }

        public async Task<double[]> run(double[] data)
        {
            RunQuery query = new RunQuery("run", data);
            object[] result = (object[])(await networkQuery(query));

            List<double> results = new List<double>();
            foreach (object r in result)
                results.Add((double)r);
            return results.ToArray();
        }

        public Task<object> query(object data)
        {
            QueryQuery query = new QueryQuery("query", data);
            return networkQuery(query);
        }

        public class TrainOutput
        {
            public double error;
            public int iterations;

            public TrainOutput(object input)
            {
                var dict = (IDictionary<string, object>)(input);
                error = (double)dict["error"];
                iterations = (int)dict["iterations"];
            }

            public override string ToString()
            {
                return "Error: " + error + "; Iterations: " + iterations;
            }
        }

        private abstract class NetworkQuery
        {
            public string mode;

            public NetworkQuery(string mode)
            {
                this.mode = mode;
            }
        }
        private class TrainQuery : NetworkQuery
        {
            public ICollection<TrainingItem> data;
            public Dictionary<string, object> trainSettings;

            public Func<object, Task<object>> loggingFunction;

            public TrainQuery(string mode, ICollection<TrainingItem> data) : base(mode)
            {
                this.data = data;
                trainSettings = new Dictionary<string, object>();


                trainSettings.Add("errorThresh", 0.0005);
                trainSettings.Add("callbackPeriod", 100);
                trainSettings.Add("learningRate", 0.1);


                loggingFunction = (Func<object, Task<object>>)(async (message) =>
                {
                    Console.WriteLine(new TrainOutput(message).ToString());
                    return null;
                });
            }
        }
        private class RunQuery : NetworkQuery
        {
            public double[] data;

            public RunQuery(string mode, double[] data)
                : base(mode)
            {
                this.data = data;
            }
        }
        private class QueryQuery : NetworkQuery
        {
            public object data;

            public QueryQuery(string mode, object data)
                : base(mode)
            {
                this.data = data;
            }
        }
    }

    public class TrainingItem
    {
        /// These names and types are important, since this is how they appear
        /// marshalled in Node.js, where brain requires these fields in the
        /// training data.
        public double[] input;
        public double[] output;

        public TrainingItem()
        { }

        public TrainingItem(double[] input, double[] output)
        {
            this.input = input;
            this.output = output;
        }
    }
}