using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikPlatformDriver
{
    internal class InverseKinematic
    {
		private double[,] AAIS = new double[6, 3];
		private double[,] BBII = new double[6, 3];
		private double[,] LLIS = new double[3, 3];


		private double[,] Ra = new double[3, 3];
		private double[,] Rb = new double[3, 3];
		private double[,] Rc = new double[3, 3];
		private double[,] R1 = new double[3, 3];
		private double[] PseudoVector = new double[3];

		private int jack;

		private double alfa, beta, gama;

		private PointDef[] Ljack = new PointDef[6];

		private readonly double D2R;

		public InverseKinematic()
		{
			D2R = Math.PI / 180;
			for (int i = 0; i < Ljack.Length; ++i)
			{
				Ljack[i] = new PointDef();
			}

		}

		private void Mult3x3Matrice(double[,] a, double[,] b, double[,] result)
		{
			int i, j, k;
			for (i = 0; i < 3; i++)
			{
				for (j = 0; j < 3; j++)
				{
					for (k = 0; k < 3; k++)
					{
						result[i, j] += a[i, k] * b[k, j];
					}
				}
			}
		}


		public void InverseKinematics(double[] X1, double[] Y1)
		{

			AAIS[0, 0] = 234.9709134;
			AAIS[0, 1] = 48.87402027;
			AAIS[0, 2] = 0;

			AAIS[1, 0] = -75.15931356;
			AAIS[1, 1] = 227.9277903;
			AAIS[1, 2] = 0;

			AAIS[2, 0] = -159.8115998;
			AAIS[2, 1] = 179.05377;
			AAIS[2, 2] = 0;

			AAIS[3, 0] = -159.8115998;
			AAIS[3, 1] = -179.05377;
			AAIS[3, 2] = 0;

			AAIS[4, 0] = -75.15931356;
			AAIS[4, 1] = -227.9277903;
			AAIS[4, 2] = 0;

			AAIS[5, 0] = 234.9709134;
			AAIS[5, 1] = -48.87402027;
			AAIS[5, 2] = 0;

			BBII[0, 0] = 230.8645156;
			BBII[0, 1] = 329.7086978;
			BBII[0, 2] = 0;

			BBII[1, 0] = 170.1038504;
			BBII[1, 1] = 364.7888843;
			BBII[1, 2] = 0;

			BBII[2, 0] = -400.968366;
			BBII[2, 1] = 35.08018646;
			BBII[2, 2] = 0;

			BBII[3, 0] = -400.968366;
			BBII[3, 1] = -35.08018646;
			BBII[3, 2] = 0;

			BBII[4, 0] = 170.1038504;
			BBII[4, 1] = -364.7888843;
			BBII[4, 2] = 0;

			BBII[5, 0] = 230.8645156;
			BBII[5, 1] = -329.7086978;
			BBII[5, 2] = 0;


			alfa = X1[3] * D2R;
			beta = X1[4] * D2R;
			gama = X1[5] * D2R;


			Ra[0, 0] = 1;
			Ra[0, 1] = 0;
			Ra[0, 2] = 0;
			Ra[1, 0] = 0;
			Ra[1, 1] = Math.Cos(alfa);
			Ra[1, 2] = -1 * Math.Sin(alfa);
			Ra[2, 0] = 0;
			Ra[2, 1] = Math.Sin(alfa);
			Ra[2, 2] = Math.Cos(alfa);

			Rb[0, 0] = Math.Cos(beta);
			Rb[0, 1] = 0;
			Rb[0, 2] = Math.Sin(beta);
			Rb[1, 0] = 0;
			Rb[1, 1] = 1;
			Rb[1, 2] = 0;
			Rb[2, 0] = -1 * Math.Sin(beta);
			Rb[2, 1] = 0;
			Rb[2, 2] = Math.Cos(beta);

			Rc[0, 0] = Math.Cos(gama);
			Rc[0, 1] = -1 * Math.Sin(gama);
			Rc[0, 2] = 0;
			Rc[1, 0] = Math.Sin(gama);
			Rc[1, 1] = Math.Cos(gama);
			Rc[1, 2] = 0;
			Rc[2, 0] = 0;
			Rc[2, 1] = 0;
			Rc[2, 2] = 1;


			R1[0, 0] = 0;
			R1[0, 1] = 0;
			R1[0, 2] = 0;
			R1[1, 0] = 0;
			R1[1, 1] = 0;
			R1[1, 2] = 0;
			R1[2, 0] = 0;
			R1[2, 1] = 0;
			R1[2, 2] = 0;

			LLIS[0, 0] = 0;
			LLIS[0, 1] = 0;
			LLIS[0, 2] = 0;
			LLIS[1, 0] = 0;
			LLIS[1, 1] = 0;
			LLIS[1, 2] = 0;
			LLIS[2, 0] = 0;
			LLIS[2, 1] = 0;
			LLIS[2, 2] = 0;


			Mult3x3Matrice(Rc, Rb, R1);
			Mult3x3Matrice(R1, Ra, LLIS);

			PseudoVector[0] = X1[0];
			PseudoVector[1] = X1[1];
			PseudoVector[2] = X1[2] + 533.4345;


			// +++ CALCULATING INVERSE KINEMATICS ++++ //

			for (jack = 0; jack < 6; jack++)
			{

				Ljack[jack].X = LLIS[0, 0] * AAIS[jack, 0] + LLIS[0, 1] * AAIS[jack, 1] + LLIS[0, 2] * AAIS[jack, 2] + PseudoVector[0] - BBII[jack, 0];
				Ljack[jack].Y = LLIS[1, 0] * AAIS[jack, 0] + LLIS[1, 1] * AAIS[jack, 1] + LLIS[1, 2] * AAIS[jack, 2] + PseudoVector[1] - BBII[jack, 1];
				Ljack[jack].Z = LLIS[2, 0] * AAIS[jack, 0] + LLIS[2, 1] * AAIS[jack, 1] + LLIS[2, 2] * AAIS[jack, 2] + PseudoVector[2] - BBII[jack, 2];

				Y1[jack] = Math.Sqrt(Ljack[jack].X * Ljack[jack].X + Ljack[jack].Y * Ljack[jack].Y + Ljack[jack].Z * Ljack[jack].Z) - 603;
			}

		}


		private class PointDef
		{
			public double X { get; set; }
			public double Y { get; set; }
			public double Z { get; set; }
		}
	}
}
