using CadParcial2Saa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2Saa
{
    public class SeriesCln
    {
        public static int insertar(Series series)
        {
            using (var context = new Parcial2SaaEntities())
            {
                context.Series.Add(series);
                context.SaveChanges();
                return series.id;
            }
        }
        public static int actualizar(Series series)
        {
            using (var context = new Parcial2SaaEntities())
            {
                var existente = context.Series.Find(series.id);
                existente.titulo = series.titulo;
                existente.sinopsis = series.sinopsis;
                existente.director = series.director;
                existente.episodios = series.episodios;
                existente.fechaEstreno = series.fechaEstreno;
                existente.urlPortada = series.urlPortada;
                existente.ididiomaOriginal = series.ididiomaOriginal;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id)
        {
            using (var context = new Parcial2SaaEntities())
            {
                var series = context.Series.Find(id);
                series.estado = -1;
                return context.SaveChanges();
            }
        }
        public static Series obtenerUno(int id)
        {
            using (var context = new Parcial2SaaEntities())
            {
                return context.Series.Find(id);
            }
        }
        public static List<Series> listar()
        {
            using (var context = new Parcial2SaaEntities())
            {
                return context.Series.Where(x => x.estado == 1).ToList();
            }
        }

        public static List<paSerieListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2SaaEntities())
            {
                return context.paSerieListar(parametro).ToList();
            }
        }


    }
}
