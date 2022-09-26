namespace RESTAPI_CORE.Datos
{
    internal static class DAO
    {
        public static string ToString(object o)
        {
            return (string.IsNullOrWhiteSpace(o.ToString())) ? string.Empty : o.ToString();
        }

        public static int ToInt(object o)
        {
            return (ToString(o) == string.Empty) ? 0 : int.Parse(ToString(o));
        }

        public static bool ToBool(object o)
        {
            return (ToString(o) == string.Empty) ? false : bool.Parse(ToString(o));
        }

        public static double ToDouble(object o)
        {
            return (ToString(0) == string.Empty) ? 0 : double.Parse(ToString(o));
        }

        public static decimal ToDecimal(object o)
        {
            return (ToString(o) == "0") ? 0 : decimal.Parse(ToString(o));
        }

        public static DateTime? ToDateTime(object o)
        {
            DateTime? rpt = null;
            DateTime temp;
            if (DateTime.TryParse(ToString(o), out temp)) { rpt = temp; }
            return rpt;
        }

    }
}
