using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
     private List<Serie> listaSerie = new List<Serie>();

    {
		public void Atualiza(int id, Serie serie)
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = serie;
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie.RemoveAt(id);
			listaSerie[id].Excluir();
		}

		public void Insere(Serie serie)
		public void Insere(Serie objeto)
		{
			listaSerie.Add(serie);
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public Serie RetornaPorId(int id)
		public int ProximoId()
		{
			return listaSerie[id];
			return listaSerie.Count;
		}

		public int ProximoId()
		public Serie RetornaPorId(int id)
		{
			return listaSerie.Count;
			return listaSerie[id];
		}
	}

} 