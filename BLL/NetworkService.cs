using System;
using System.Collections.Generic;
using ENTITY;
using DAL;
namespace BLL
{
    public class NetworkService
    {
        NetworkRepository networkRepository = new NetworkRepository();
        public double[,] ReadSimulationPatterns(string path)
        {
            return networkRepository.ReadSimulationPatterns(path);
        }
        public Network ReadDataTrain(string path)
        {
            return networkRepository.ReadDataTrain(path);
        }
        public void SaveNetworkTrainParams(string path, List<string> values)
        {
            networkRepository.SaveNetworkTrainParams(path, values);
        }
        public TrainParams ReadNetworkTrainParams(string path)
        {
            return networkRepository.ReadNetworkTrainParams(path);
        }
    }
}
