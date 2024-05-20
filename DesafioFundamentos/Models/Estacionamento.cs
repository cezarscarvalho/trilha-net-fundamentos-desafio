
namespace DesafioFundamentos.Models

{
   using System;
using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class Estacionamento
    {
       
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            if (!string.IsNullOrWhiteSpace(placa)){
                Console.WriteLine("Placa adicionada com sucesso!");
            }
            else {
                Console.WriteLine("Placa em branco!");
                
            }
        }

        public void RemoverVeiculo()
        {
          
          decimal valorTotal;
          decimal horaSaida;
           
            Console.WriteLine("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            if (veiculos.Contains(placa)) {
            
            
            Console.WriteLine("Digite 1 para Remover\t");
            Console.WriteLine(" Ou 0 para sair:\t ");
            string resposta = Console.ReadLine();   
                      
                   
            if (resposta=="1") {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                 horaSaida = Convert.ToDecimal(Console.ReadLine());

                valorTotal = (precoInicial + precoPorHora) * horaSaida;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }  
            
     else if (resposta=="0") {
        Console.WriteLine("Finalizando...");
        
        
    }
  else  {
    Console.WriteLine("Opção Inválida");
  }
            }
            else {
                Console.WriteLine("Placa não encontrada");
            }
            
         
       }

        public void ListarVeiculos()
        {

                Console.WriteLine("Digite 1 para Listar todos os Veículos\t");
            Console.WriteLine("Digite 2 para localizar uma placa\t");
            Console.WriteLine("Digite 0 para Sair");
            string opcao = Console.ReadLine();  
            
                           
                    
                   
            if (opcao=="1") {
               
             Console.WriteLine("Pressione <ENTER> para listar os veículos cadastrados: ");
             Console.ReadLine();          
             
            foreach (string listarPlacas in veiculos)
           
             Console.WriteLine($"Os veículos estacionados são:  {listarPlacas}");

            }
                           
            else if (opcao=="2") {

                 Console.WriteLine("Digite uma placa para pesquisa:\t ");
                 string pesqPlacas = Console.ReadLine();
       
           if(veiculos.Contains(pesqPlacas)) {

                 Console.WriteLine($"Veículo encontrado no cadastro");
            }

            else {
                Console.WriteLine("Placa não encontrada");
            }
            
  
            if (opcao=="0") {
                Console.WriteLine("Finalizando...");
            }

         else  {


           Console.WriteLine("Opção Inválida");
       } 
        }
        
        }
        
    }
}
                  
   

        
   
                      
                  
             
               
               
              
              
            
               
               
              
            
            
            
                                  
              
                      
       
            
            
            
            

            
            
    
    




