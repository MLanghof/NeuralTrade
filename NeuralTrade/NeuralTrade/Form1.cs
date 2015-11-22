using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EdgeJs;
using System.Net;

namespace NeuralTrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static async void Run()
        {
            var func = Edge.Func(@"
                return function(data, callback) {
                    callback(null, net.run(data)[0]);
                }");
            double[] input = new double[1];
            input[0] = 0.1;

            Console.WriteLine(await func(input));
        }

        public static async void Train()
        {
            var trainNetwork = Edge.Func(@"
                var brain = require('brain');

                return function (data, cb) {
                    var net = new brain.NeuralNetwork({
                            hiddenLayers: [2]
                        });

                    var output = net.train([
                            {input: [0], output: [0]},
                            {input: [0.25], output: [0.0625]},
                            {input: [0.5], output: [0.25]},
                            {input: [0.75], output: [0.5625]},
                            {input: [1], output: [1]}
                        ]);
                    cb(null, output.error)
                };
            ");

            List<Dictionary<string, double[]>> data = new List<Dictionary<string, double[]>>();

            Console.WriteLine("Error: " + (await trainNetwork(data)));
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            Task.Run((Action)Train).Wait();
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            Task.Run((Action)Run).Wait();
        }
    }
}
