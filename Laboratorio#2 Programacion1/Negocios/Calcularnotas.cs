using Laboratorio_2_Programacion1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Programacion1.Negocios
{
	public class Calcularnotas
	{

		public void calcNotLab1(Notas nota) 
		{
			decimal lab1 = nota.Lab1 * 0.4M;

			nota.Lab1 = lab1;

		}

		public void calcNotLab2(Notas nota)
		{
			decimal lab2 = nota.Lab2 * 0.4M;

			nota.Lab2 = lab2;

		}

		public void calcNotLab3(Notas nota)
		{
			decimal lab3 = nota.Lab3 * 0.4M;

			nota.Lab3 = lab3;

		}




		public void calcNotPar1(Notas nota) 
		{
			decimal parc1 = nota.Parcial1 * 0.6M;

			nota.Parcial1 = parc1;
		}

		public void calcNotPar2(Notas nota)
		{
			decimal parc2 = nota.Parcial2 * 0.6M;

			nota.Parcial2 = parc2;
		}
		public void calcNotPar3(Notas nota)
		{
			decimal parc3 = nota.Parcial3 * 0.6M;

			nota.Parcial3 = parc3;
		}


		public void Resultado(Notas notas) 
		{
			decimal R = notas.Lab1 + notas.Parcial1 + notas.Lab2 + notas.Parcial2 + notas.Lab3 + notas.Parcial3 ;

			decimal R2 = R / 3;
			notas.Resultado = R2;
		}
		
	}
}
