using System;
using System.Collections.Generic;

namespace NEA_project
{
    class Predictions
    {
        private static Tuple<double, double> calcMovingAvg(string item) // retrieve quarterly data for selected item + calculate moving averages
        {
            List<string> q1 = SQLOperations.sqlSelect("select P1 from Financial where name = \"" + item + "\"");
            List<string> q2 = SQLOperations.sqlSelect("select P2 from Financial where name = \"" + item + "\"");
            List<string> q3 = SQLOperations.sqlSelect("select P3 from Financial where name = \"" + item + "\"");
            List<string> q4 = SQLOperations.sqlSelect("select P4 from Financial where name = \"" + item + "\"");

            double p1 = double.Parse(q1[0].ToString());
            double p2 = double.Parse(q2[0].ToString());
            double p3 = double.Parse(q3[0].ToString());
            double p4 = double.Parse(q4[0].ToString());

            double movAvg1 = (p1 + p2 + p3) / 3;
            double movAvg2 = (p2 + p3 + p4) / 3;

            return new Tuple<double, double>(movAvg1, movAvg2); // for returning multiple values
        }

        private static double getResponseFactor(string item, string trigger) // retrieve response factor and multiply with extrapolated data
        {
            List<string> factor = SQLOperations.sqlSelect("select responseFactor from responses inner join triggers on responses.triggerID = triggers.triggerID inner join financial on triggers.financialID = financial.financialID where triggers.triggerWord = \"" + trigger + "\" and financial.name = \"" + item + "\"");
            double f = double.Parse(factor[0]); // because data is returned as a list of strings
            return f;
        }

        private static double extrapolate(double[,] d, int p) // extrapolates data
        {
             // linear extrapolation formula - based on plotting data on a graph, where the
            //  gradient represents a trend and extrapolating it can predict future performance

            double value = d[0, 1] + (p - d[0, 0]) / (d[1, 0] - d[0, 0]) * (d[1, 1] - d[0, 1]);
            return value;
        }

        public static string getPredicts(string item, string trigger) // returns predictions when called
        {
            // get data
            var averages = calcMovingAvg(item);
            double factor = getResponseFactor(item, trigger);
            
            // calculate predictions
            int period = 5; // (arbritrary) period that predictions are for
            double[,] dataset = {{ 2, averages.Item1 }, { 3, averages.Item2 }};
            double value = extrapolate(dataset, period) * factor; // extrapolates data and multiplies by response factor

            // calculate change direction and difference
            List<string> p4 = SQLOperations.sqlSelect("select P4 from Financial where name = \"" + item + "\""); // get most recent financial data
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
            else // (value == current)
            {
                change = "No change"; // the chance of this is absolutely tiny but i need to prepare anyway
            }

            // return item + ": " + change + " by " + percent + " to " + value + ", Change of " + difference; // prediction string to be returned
            
            //const int strdiff = -5;
            return $"{item,-5} {change} - change by {percent:0.##}% to {value:0.##} - change of {difference:0.##}";
        }
    }
}