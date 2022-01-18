using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_project
{
    class Predictions
    {
        private static Tuple<double, double> calcMovingAvg(string item) // retrieve quarterly data for selected item + calculate moving averages
        {
            List<string> quarterlyData = SQLOperations.sqlSelect("select P1 P2 P3 P4 from Financial where name = " + item);

            double p1 = double.Parse(quarterlyData[0]);
            double p2 = double.Parse(quarterlyData[1]);
            double p3 = double.Parse(quarterlyData[2]);
            double p4 = double.Parse(quarterlyData[3]);

            double movAvg1 = (p1 + p2 + p3) / 3;
            double movAvg2 = (p2 + p3 + p4) / 3;

            return new Tuple<double, double>(movAvg1, movAvg2); // for returning multiple values
        }

        private static double getResponseFactor(string item) // retrieve response factor and multiply with extrapolated data
        {
            List<string> factor = SQLOperations.sqlSelect("select responseFactor from Response where ");
            double f = double.Parse(factor[0]); // because data is returned as a list
            return f;
        }

        private static double extrapolate(double[,] d, int p) // extrapolates data
        {
             // linear extrapolation formula - based on plotting data on a graph, where the
            // gradient represents a trend and extrapolating it can predict future performance

            double value = d[0, 1] + (p - d[0, 0]) / (d[1, 0] - d[0, 0]) * (d[1, 1] - d[0, 1]);
            return value;
        }

        public static string getPredicts(string item) // returns predictions when called
        {
            // get data
            var averages = calcMovingAvg(item);
            double factor = getResponseFactor(item);
            
            // calculate predictions
            int period = 4; // (arbritrary) period that predictions are for
            double[,] dataset = {{ 1, averages.Item1 }, { 2, averages.Item2 }};
            double value = extrapolate(dataset, period) * factor; // extrapolates data and multiplies by response factor

            // calculate change direction and difference
            List<string> p4 = SQLOperations.sqlSelect("select P4 from Financial where name = " + item); // get most recent financial data
            double current = double.Parse(p4[0]);
            double difference = (value - current);
            double percent = (difference / current) * 100;
            string change;
            if (value > current)
            {
                change = "Increase";
            }
            else if (value < current)
            {
                change = "Decrease";
            }
            else
            {
                change = "No change"; // the chance of this is absolutely tiny but i need to prepare anyway
            }

            return item + ": " + change + " by " + percent + " to " + value + ", Change of " + difference; // prediction string
        }
    }
}