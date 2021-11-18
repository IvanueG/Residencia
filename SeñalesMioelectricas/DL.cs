using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeñalesMioelectricas
{
    public class  DL    
    {
        BaseDeDatosDataContext db = new BaseDeDatosDataContext();

        public List<ReporteV> listareporte()
        {
            List<ReporteV> list = db.ReporteVs.ToList();
            return list;
        }



    }
}
