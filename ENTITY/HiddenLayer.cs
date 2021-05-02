using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ENTITY
{
    public class HiddenLayer
    {
        public int NoNeurons { get; set; }
        public string ActivationFunction { get; set; }
        public HiddenLayer(int noNuerons, string activationFunction)
        {
            NoNeurons = noNuerons;
            ActivationFunction = activationFunction;
        }
        public double ApplicateFA(double value,bool derivate) {
            if (ActivationFunction.Equals("SIGMOIDE")) {
                if (derivate) return CalculateSigmodeaDerivated(value);
                return CalculateSigmodea(value);
            }
            else {
                if (ActivationFunction.Equals("GAUSIANA"))
                {
                    if (derivate) return CalculateGaussianDerivated(value);
                    return CalculateGaussian(value);
                }
                else {
                    if (derivate) return CalculateTanHDerivated(value);
                    return CalculateTanH(value);
                }
            }
        }
        public double CalculateSigmodea(double value)
        {
            double result;
            result = 1 / (1 + Math.Exp(-value));
            return result;
        }
        public double CalculateSigmodeaDerivated(double value)
        {
            double y=CalculateSigmodea(value);
            return y * (1 - y);
        }
        public double CalculateTanH(double value) {
            var result = Math.Tanh(value);
            return result;
        }
        public double CalculateTanHDerivated(double value)
        {
            double a = CalculateTanH(value);
            var result = 1 - (a * a);
            return result;
        }

        public double CalculateGaussian(double value) {
            double finalValue = value * value;
            double a = Math.Exp(-value);
            return a;
        }
        public double CalculateGaussianDerivated(double value)
        {
            double finalValue = value * value;
            double a = Math.Exp(-finalValue);
            return a;
        }
    }
}
