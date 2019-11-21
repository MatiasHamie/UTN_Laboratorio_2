using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo + ".txt");
            StreamWriter streamWriter = new StreamWriter(pathArchivoEnEscritorio, true);
            try
            {
                streamWriter.WriteLine(datos.Dequeue());
            }
            catch (Exception exc)
            {
                throw new Exception("Error al guardar .TXT",exc);
            }
            finally
            {
                streamWriter.Close();
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {

            string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo + ".txt");
            StreamReader streamReader = new StreamReader(pathArchivoEnEscritorio);

            Queue<Patente> auxQueue = new Queue<Patente>();
            Patente auxPatente = new Patente();
            string auxCodigoPatente = "";

            try
            {
                while (!streamReader.EndOfStream)
                {
                    auxCodigoPatente = streamReader.ReadLine();
                    auxPatente = auxCodigoPatente.ValidarPatente();

                    if(auxPatente != null)
                    {
                        auxQueue.Enqueue(auxPatente);
                        
                    }
                }

                //foreach (Patente item in auxQueue)
                //{
                //    datos.Enqueue(item);
                //}

                //datos = auxQueue;
            }
            catch (Exception)
            {
                
                //throw new Exception("Error al leer .TXT", exc);
            }
            finally
            {
                streamReader.Close();
            }

            datos = auxQueue;
        }
    }
}
