using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;

namespace NeuralTrade
{
    public partial class Form1 : Form
    {
        NetworkHandler network;

        public Form1()
        {
            InitializeComponent();

            network = new NetworkHandler();
        }

        public async void Run()
        {
            for (double x = 0; x <= 1; x += 0.05)
            {
                double[] data = new double[] { x };
                var result = (await network.run(data));
                Console.WriteLine("Result for " + x + ": " + Math.Sqrt(result[0]));
            }
        }

        public async void Train()
        {
            List<TrainingItem> data = new List<TrainingItem>();

            for (double x = 0; x <= 1; x += 0.01)
            {
                var entry = new TrainingItem();
                entry.input = new double[1] { x };
                entry.output = new double[1] { x * x };
                data.Add(entry);
            }

            var result = (await network.train(data));
            Console.WriteLine(result.ToString());
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
