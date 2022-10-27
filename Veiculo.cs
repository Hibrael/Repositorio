namespace BANCOSOLUÇÃO
{
    public abstract class Veiculo
    {
   
        public string Placa {get; set;}
        public string Modelo {get; set;}
        public DateTime AnoFabricação {get; set;}
        public int IdadeVeiculo 
        {
            get
            {
                return (DateTime.Now.Year - AnoFabricação.Year);
            }
        }
        public double ValorPedagio {get; set;}

        public abstract double PagarPedagio();
        
    }
}