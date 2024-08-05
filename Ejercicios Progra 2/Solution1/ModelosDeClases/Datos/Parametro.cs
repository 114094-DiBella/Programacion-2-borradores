namespace ModelosDeClases.Datos
{
    public class Parametro
    {
        public string Clave { get; set; }
        public object Valor { get; set; }

        public Parametro(string clave, object valor)
        {
            Clave = clave;
            Valor = valor;
        }
    }
}