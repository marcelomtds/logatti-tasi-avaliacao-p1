namespace Dominio
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public int NumeroSala { get; set; }
        public override string ToString()
        {
            return $"{Nome} - das {HoraInicio} às {HoraFim} - Carga Horária: {CargaHoraria} horas - Sala: {NumeroSala}";
        }
    }
}