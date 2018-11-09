using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simulador_de_negocios.Models;
namespace simulador_de_negocios.Data
{
    public class DbInitializer
    {
        public static void Initialize(simulador_de_negociosContext context)
        {
            context.Database.EnsureCreated();
            if (context.Mano_Obra_Operativa.Any())
            {
                return;
            }
            var mano_Obra_Operativas = new Mano_Obra_Operativa[]
            {

            };
            foreach (Mano_Obra_Operativa a in mano_Obra_Operativas)
            {
                context.Mano_Obra_Operativa.Add(a);
                {
                    context.SaveChanges();
                }
            }
        }
    }
}