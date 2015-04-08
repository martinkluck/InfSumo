using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Tema
/// </summary>
public class Categorias
{
    private String s_Categoria;
    public Categorias()
    {
    }
    public Categorias(String s_Categoria)
    {
        this.s_Categoria = s_Categoria;
    }
    public String Categoria
    {
        get
            {
            return s_Categoria;
            }
        set
            {
            s_Categoria = value;
            }
    }
}