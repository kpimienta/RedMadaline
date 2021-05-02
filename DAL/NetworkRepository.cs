using System;
using ENTITY;
using System.IO;
using System.Collections.Generic;

namespace DAL
{
    public class NetworkRepository
    {
        FileStream fileStream;
        double[,] patternsInputArray;
        double[,] patternsOutputArray;
        double[,] _weights;
        double[] _threshold;
        public Network ReadDataTrain(string path)
        {
            int noPatterns = 0;
            int noInputs = 0, noOutputs = 0;
            StreamReader sr = File.OpenText(path);
            StreamReader auxSr = File.OpenText(path);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                if (noPatterns == 0)
                {
                    var a = s.Split(';');
                    var inputs = a[0].Split('/');
                    var outputs = a[1].Split('/');
                    noInputs = inputs.Length;
                    noOutputs = outputs.Length;
                }
                noPatterns++;
            }
            patternsInputArray = new double[noPatterns, noInputs];
            patternsOutputArray = new double[noPatterns, noOutputs];
            int currentPattern = 0;
            while ((s = auxSr.ReadLine()) != null)
            {
                var a = s.Split(';');
                var inputs = a[0].Split('/');
                var outputs = a[1].Split('/');
                for (int i = 0; i < inputs.Length; i++)
                {
                    patternsInputArray[currentPattern, i] = double.Parse(inputs[i]);
                }
                for (int i = 0; i < outputs.Length; i++)
                {
                    patternsOutputArray[currentPattern, i] = double.Parse(outputs[i]);
                }
                currentPattern++;
            }
            Network network = new Network();
            network.InputsPatterns = patternsInputArray;
            network.OutputsPatterns = patternsOutputArray;
            network.NoPatterns = noPatterns;
            network.NoInputs = noInputs;
            network.NoOutputs = noOutputs;
            return network;
        }
        public void SaveNetworkTrainParams(string path, List<string> values)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (var item in values)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }
        public TrainParams ReadNetworkTrainParams(string path)
        {
            StreamReader sr = File.OpenText(path);
            StreamReader auxSr = File.OpenText(path);
            string s = "";
            int columns = 0;
            int rows = 0;
            while ((s = sr.ReadLine()) != null)
            {
                var a = s.Split(';');
                var weights = a[0].Split('/');
                var threshold = a[1];
                if (rows == 0) columns = weights.Length;
                rows++;
            }
            _weights = new double[rows, columns];
            _threshold = new double[rows];
            int currentRow = 0;
            while ((s = auxSr.ReadLine()) != null)
            {
                var a = s.Split(';');
                var weights = a[0].Split('/');
                var threshold = a[1];
                for (int i = 0; i < weights.Length; i++)
                {
                    _weights[currentRow, i] = double.Parse(weights[i]);
                }
                _threshold[currentRow] = double.Parse(threshold);
                currentRow++;
            }
            TrainParams trainParams = new TrainParams();
            trainParams.Threshold = _threshold;
            trainParams.Weights = _weights;
            return trainParams;
        }
        public double[,] ReadSimulationPatterns(string path)
        {
            StreamReader sr = File.OpenText(path);
            StreamReader auxSr = File.OpenText(path);
            string s = "";
            var columns = 0;
            var rows = 0;
            while ((s = sr.ReadLine()) != null)
            {
                var a = s.Split(';');
                if (rows == 0) columns = a.Length;
                rows++;
            }
            double[,] result = new double[rows, columns];
            int currentRow = 0;
            while ((s = auxSr.ReadLine()) != null)
            {
                var a = s.Split(';');
                for (int i = 0; i < a.Length; i++)
                {
                    result[currentRow, i] = double.Parse(a[i]);
                }
                currentRow++;

            }
            return result;

        }


    }
}
