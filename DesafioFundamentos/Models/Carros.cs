using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentosCarros.Models
{
    public class Carros 
    {
         //Criando um construtor vazio
        public Carros ()
        {

        }
        //Criando um construtor para o carro
        public Carros (string nome, string cor, string placa)
        {
            NomeCarro = nome;
            CorCarro = cor;
            Placa = placa;
        }

        //Criando variaveis para armazenar os valores digitados
        private string _nome;
        private string _cor;
        private string _placa;

        //
        public string NomeCarro 
        { 
            get=> _nome.ToUpper(); 
        
            set
            {
                if (value =="")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            } 
        
         }
        public string CorCarro 
        {  get=> _cor.ToUpper(); 
        
            set
            {
                if (value =="")
                {
                    throw new ArgumentException("O campo cor não pode ser vazio");
                }
                _cor = value;
            }  
        }
        public string Placa 
        { get=> _placa.ToUpper(); 
        
            set
            {
                if (value =="")
                {
                    throw new ArgumentException("O campo placa não pode ser vazio");
                }
                _placa = value;
            } 
        }
       public string CarroCompleto 
       { 
        get => $" Carro: {NomeCarro}, Cor: {CorCarro}, Placa: {Placa} ";        
        
        }
        public DateTime HorarioEntrada { get; internal set; }

        public void ApresentarCarro ()
        {

            Console.WriteLine($"{CarroCompleto.ToUpper()}"); 
        }


    }
    
}