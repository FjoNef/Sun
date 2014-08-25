using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sun
{
    class Sun
    {
        private double LocalStandartTimeMeridian;
        private double DayOfYear;
        private double EquationOfTime;
        private double TimeCoeficent;
        private double LocalSolarTime;
        private double HourAngle;

        private void LSTM(int dTime)
        {
            LocalStandartTimeMeridian = 15 * dTime;
        }
        private void DoY(DateTime date)
        {
            DayOfYear = date.DayOfYear;
        }
        private void EoT()
        {
            double B = (360.0 / 365.0) * (DayOfYear - 81.0);
            EquationOfTime = Math.Round(9.87 * Math.Sin(((2.0 * B) / 180.0) * Math.PI) - 7.53 * Math.Cos((B / 180.8) * Math.PI) - 1.5 * Math.Sin((B / 180.0) * Math.PI));
        }

        private void TC(decimal longitude)
        {
            TimeCoeficent = 4*(LocalStandartTimeMeridian - (double)longitude) + EquationOfTime;
        }

        private void LST(DateTime time)
        {
            double localTime = (double)time.Hour + (double)time.Minute/60.0;
            LocalSolarTime = localTime + (TimeCoeficent / 60.0);
        }

        private void HRA()
        {
            HourAngle = 15.0 * (LocalSolarTime - 12.0);
        }

        public double Calculate(decimal longitude, DateTime date, DateTime time, int dTime)
        {
            LSTM(dTime);
            DoY(date);
            EoT();
            TC(longitude);
            LST(time);
            HRA();
            return HourAngle;
        }
    }
}
