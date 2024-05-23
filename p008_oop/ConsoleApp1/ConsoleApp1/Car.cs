using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car
{
    //field or attribute (membro da classe)
    //modificador de acesso: public
    public string color;
    public int anoFabricacao;
    public bool ligado;
    public string modelo;

    //por padrão será private, quando não especificar o encapsulamento
    string chassi;

    public string estaLigado()
    {
        return ligado ? "Ligado" : "Desligado";
    }

    //usando construtor: mesmo nome da classe e sem return type
    public Car()
    {
        ligado = false;
    }

    //overloading de construtor
    public Car(bool ligado)
    {
        this.ligado = ligado;
    }

    public Car(string cor, int anoFabricado, bool ligado, string modelo)
    {
        color = cor;
        anoFabricacao = anoFabricado;
        this.ligado = ligado;
        this.modelo = modelo;
    }

    public void setChassi(string chassi)
    {
        this.chassi = chassi;
    }

    public string getChassi()
    {
        return chassi;
    }

}

