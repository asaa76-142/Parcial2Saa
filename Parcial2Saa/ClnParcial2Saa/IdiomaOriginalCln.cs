using CadParcial2Saa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2Saa
{
    public class IdiomaOriginalCln
    {
        public static List<IdiomaOriginal> listar()
        {
            using (var context = new Parcial2SaaEntities())
            {
                return context.IdiomaOriginal.Where(x => x.estado != -1).ToList();
            }
        }

    }
}
