using System;

namespace csharp.Model
{
    public class CartaoDeCredito
    {
        public int numero { get; set; }
        public string dataDeValidade { get; set; }
        public Cliente cliente { get; set; }

        public CartaoDeCredito(int numero){
          this.numero = numero;
        }
    }
}