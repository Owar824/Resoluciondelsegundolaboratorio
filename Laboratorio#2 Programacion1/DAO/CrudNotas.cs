using Laboratorio_2_Programacion1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Programacion1.DAO
{
	public class CrudNotas
	{

		public void AgregarNotas(Notas notas)
		{
			using (NotaEstudianteContext db = new NotaEstudianteContext())
			{
				Notas nota = new Notas();
				nota.NombreEstudiante = notas.NombreEstudiante;
				nota.Materia = notas.Materia;
				nota.Lab1 = notas.Lab1;
				nota.Parcial1 = notas.Parcial1;
				nota.Lab2 = notas.Lab2;
				nota.Parcial2 = notas.Parcial2;
				nota.Lab3 = notas.Lab3;
				nota.Parcial3 = notas.Parcial3;
				nota.Resultado = notas.Resultado;
				db.Nota.Add(nota);
				db.SaveChanges();
			}
		}	

		public List<Notas> listarnota() 
		{
			using (NotaEstudianteContext db = new NotaEstudianteContext()) 
			{
				return db.Nota.ToList();
			}


		}
	}	 
}
      
	

