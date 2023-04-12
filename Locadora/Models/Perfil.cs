using System;
using System.ComponentModel;

namespace Locadora.Models
{
    public enum Perfil
    {
        [Description("Administrador")]
        Adm = 0,
        [Description("Funcionário")]
        Funcionario = 1
    }
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
