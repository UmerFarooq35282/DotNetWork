
namespace Snake
{
    public class Possition
    {
        public int Row { get; }
        public int Column { get; }

        public Possition(int row, int column)
        {
            Row = row; 
            Column = column;
        }
        public Possition Translate(Direction direction)
        {
            return new Possition(Row + direction.RowOffset, Column + direction.ColumnOffset);
        }

        public override bool Equals(object? obj)
        {
            return obj is Possition possition &&
                   Row == possition.Row &&
                   Column == possition.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Possition? left, Possition? right)
        {
            return EqualityComparer<Possition>.Default.Equals(left, right);
        }

        public static bool operator !=(Possition? left, Possition? right)
        {
            return !(left == right);
        }
    }
}
