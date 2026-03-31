using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;

namespace ImpliedVolatilityCalculator
{
    public partial class Form1 : Form
    {

        //Double volatility1;
        Double underlyingPrice;
        Double strikeprice;
        Double RiskFreeRate;
        Double TimeOfMaturity;
       // Double volatility2;
        Double TargetOptionPrice;
        string OptionType;
       // string OptionTypeSel;
        public Form1()
        {
            InitializeComponent();
            cmbOptionType.Items.Add("Select Option Type");
            cmbOptionType.Items.Add("Call");
            cmbOptionType.Items.Add("Put");
            cmbOptionType.SelectedIndex=0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIvResult.Text = "0.00";
        }

        private void btnCalCulate_Click(object sender, EventArgs e)
        {
            lblIvResult.Text = "0.00";
            underlyingPrice = Double.Parse(txtUnderlyingPrice.Text);
            strikeprice = Double.Parse(txtStrikePrice.Text);
            RiskFreeRate = (Double.Parse(txtInterestRate.Text)) / 100;
            TimeOfMaturity = (Double.Parse(txtTimeOfMaturity.Text)) / 365;
            TargetOptionPrice = Double.Parse(txtMarketPRice.Text);
            //OptionType = OptionTypeSel;


            //Double Impliedvol = GetIV(1, underlyingPrice, strikeprice, RiskFreeRate, TimeOfMaturity, TargetOptionPrice);
            //lblIvResult.Text = Impliedvol.ToString("0.0000");


            Double Impliedvol = CalculateImpliedVolatility(underlyingPrice, strikeprice, TimeOfMaturity, RiskFreeRate, TargetOptionPrice, OptionType) * 100.00;
            lblIvResult.Text = Impliedvol.ToString("0.0000");
        }

        //public Double GetvolatilityDetails(Double volatility1, Double underlyingPrice, Double strikeprice, Double RiskFreeRate, Double TimeOfMaturity, Double volatility2, Double TargetOptionPrice)
        //{
        //    Double d1a = (Math.Log(underlyingPrice / strikeprice) + (RiskFreeRate + 0.5 * Math.Pow(volatility1, 2)) * TimeOfMaturity) / (volatility1 * Math.Sqrt(TimeOfMaturity));
        //    Double d2a = d1a - volatility1 * Math.Sqrt(TimeOfMaturity);
        //    double Normd1a = Normal.CDF(0, 1, d1a);
        //    double Normd2a = Normal.CDF(0, 1, d2a);
        //    double CallOptionPrice1 = underlyingPrice * Normd1a - strikeprice * Math.Exp(-1 * RiskFreeRate * TimeOfMaturity) * Normd2a;


        //    Double d1b = (Math.Log(underlyingPrice / strikeprice) + (RiskFreeRate + 0.5 * Math.Pow(volatility2, 2)) * TimeOfMaturity) / (volatility2 * Math.Sqrt(TimeOfMaturity));
        //    Double d2b = d1b - volatility2 * Math.Sqrt(TimeOfMaturity);
        //    double Normd1b = Normal.CDF(0, 1, d1b);
        //    double Normd2b = Normal.CDF(0, 1, d2b);

        //    double CallOptionPrice2 = underlyingPrice * Normd1b - strikeprice * Math.Exp(-1 * RiskFreeRate * TimeOfMaturity) * Normd2b;

        //    double IV = (volatility1 + (TargetOptionPrice - CallOptionPrice1) / (CallOptionPrice2 - CallOptionPrice1) * (volatility2 - volatility1)) * 100;

        //    return IV;
        //}

        //double getOptionPrice(Double volatility1, Double underlyingPrice, Double strikeprice, Double RiskFreeRate, Double TimeOfMaturity, Double TargetOptionPrice)
        //{
        //    Double d1a = (Math.Log(underlyingPrice / strikeprice) + (RiskFreeRate + 0.5 * Math.Pow(volatility1, 2)) * TimeOfMaturity) / (volatility1 * Math.Sqrt(TimeOfMaturity));
        //    Double d2a = d1a - volatility1 * Math.Sqrt(TimeOfMaturity);
        //    double Normd1a = Normal.CDF(0, 1, d1a);
        //    double Normd2a = Normal.CDF(0, 1, d2a);
        //    return underlyingPrice * Normd1a - strikeprice * Math.Exp(-1 * RiskFreeRate * TimeOfMaturity) * Normd2a;
        //}

        //public Double GetIV(Double volatility1, Double underlyingPrice, Double strikeprice, Double RiskFreeRate, Double TimeOfMaturity, Double TargetOptionPrice)
        //{
        //    double CallOptionPrice1 = getOptionPrice(volatility1, underlyingPrice, strikeprice, RiskFreeRate, TimeOfMaturity, TargetOptionPrice);
        //    double IV = 0;
        //    double priceDiff = Math.Abs(TargetOptionPrice - CallOptionPrice1) / TargetOptionPrice;

        //    if (TargetOptionPrice - CallOptionPrice1 > 0.0001)
        //        volatility2 = volatility1 + priceDiff;
        //    else if (TargetOptionPrice - CallOptionPrice1 < -0.0001)
        //        volatility2 = volatility1 - priceDiff;
        //    else
        //    {
        //        return volatility1 * 100.00;
        //    }
        //    double CallOptionPrice2 = getOptionPrice(volatility2, underlyingPrice, strikeprice, RiskFreeRate, TimeOfMaturity, TargetOptionPrice);
        //    IV = (volatility1 + (TargetOptionPrice - CallOptionPrice1) / (CallOptionPrice2 - CallOptionPrice1) * (volatility2 - volatility1)) * 100;
        //    IV = GetIV(IV / 100.00, underlyingPrice, strikeprice, RiskFreeRate, TimeOfMaturity, TargetOptionPrice);

        //    return IV;
        //}
        public double CalculateImpliedVolatility(double S, double K, double T, double r, double optionPrice, string optionType)
        {
            Func<double, double> calculateOptionPrice = (sigma) => CalculateOptionPrice(S, K, T, r, sigma, optionType) - optionPrice;
            var impliedVolatility = FindRoots.OfFunction(calculateOptionPrice, 0.01, 1, 0.0001, 1000);
            return impliedVolatility;
        }

        private double CalculateOptionPrice(double S, double K, double T, double r, double sigma, string optionType)
        {
            var d1 = (Math.Log(S / K) + (r + 0.5 * sigma * sigma) * T) / (sigma * Math.Sqrt(T));
            var d2 = d1 - sigma * Math.Sqrt(T);

            if (optionType == "Call")
            {
                var price = S * Normal.CDF(0, 1, d1) - K * Math.Exp(-r * T) * Normal.CDF(0, 1, d2);
                return price;
            }
            else if (optionType == "Put")
            {
                var price = K * Math.Exp(-r * T) * Normal.CDF(0, 1, d1) - S * Normal.CDF(0, 1, -d2);
                return price;
            }
            else
            {
                throw new ArgumentException("Invalid option type. Must be 'call' or 'put'.", nameof(optionType));
            }
        }

        private void cmbOptionType_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            OptionType = cmbOptionType.SelectedItem.ToString();
        }
    }
}
