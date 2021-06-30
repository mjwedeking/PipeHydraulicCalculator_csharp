using System;
using System.Collections;
using System.IO;

namespace HydraulicCalc.Converters
{
	/// <summary>
	/// Summary description for HydConversion.
	/// </summary>
	public class HydConversion
	{
		private Hashtable _factors;

		public HydConversion()
		{
			_factors = new Hashtable();

			//	Flow conversion factors - input units converted to SI m3/s
			_factors.Add("gpm", 0.000063090574947062);
			_factors.Add("lps", 0.001);
			_factors.Add("mgd", 0.043812899268793);
			_factors.Add("cms", 1.0);
			_factors.Add("cfs", 0.028317016493754);
            _factors.Add("gpd", 0.000000043812899268793);

			//	Depth conversion factors - input units converted to SI meters
			_factors.Add("ft", 0.3048006096012);
            _factors.Add("inch", 0.0254000508001);
			_factors.Add("mm", 0.001);
			_factors.Add("cm", 0.01);
			_factors.Add("m", 1.0);

			//	Velocity factors converted to SI velocity unit (m/s)
            _factors.Add("fps", 0.3048006096012);
			_factors.Add("mps", 1.0);

			//	Area factors converted to SI area unit (m2)
			_factors.Add("ac", 4046.8726098737);
			_factors.Add("ha", 10000.0);
			_factors.Add("ft2", 0.092903411613263);
            _factors.Add("in2", 0.00064516);
			_factors.Add("m2", 1.0);

			//	Volume factors converted to SI area unit (m3)
			_factors.Add("usgal", 0.0037854344968237);
            _factors.Add("mg", 3785.4344968237);
			_factors.Add("l", 0.001);
            _factors.Add("ft3", 0.028317016493754);
			_factors.Add("m3", 1.0);

			// Slope factors converted to x/x
			_factors.Add("ft/ft", 1);
			_factors.Add("m/m", 1);
			_factors.Add("%", 100);
			_factors.Add("NotDefined", 1.0);


		}

		public double GetFactor(string inUnits, string outUnits)
		{
			double inFactor = 1;
			double outFactor = 1;
			try
			{
				if (_factors[inUnits] != null) inFactor = (double)_factors[inUnits];
				if (_factors[outUnits] != null) outFactor = (double)_factors[outUnits];
			}
			catch {}
			return inFactor / outFactor;
		}
	}
}