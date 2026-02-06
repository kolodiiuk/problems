using System.Collections.Generic;

public class Finder
{
    public static bool PathFinder(string maze)
    {
        var splitted = maze.Split('\n');
        var n = splitted.Length;
        var stack = new Stack<Pos>();
        var visited = new bool[n, n];
        stack.Push(new Pos(0, 0));
        while (stack.Count != 0)
        {
            var curr = stack.Pop();
            if (curr.Row == n - 1 && curr.Col == n - 1)
            {
                return true;
            }

            if (visited[curr.Row, curr.Col])
            {
                continue;
            }

            visited[curr.Row, curr.Col] = true;

            if (CanVisit(curr.Row, curr.Col + 1) && !visited[curr.Row, curr.Col + 1]) // east
            {
                stack.Push(new Pos(curr.Row, curr.Col + 1));
            }

            if (CanVisit(curr.Row, curr.Col - 1) && !visited[curr.Row, curr.Col - 1]) // west
            {
                stack.Push(new Pos(curr.Row, curr.Col - 1));
            }

            if (CanVisit(curr.Row - 1, curr.Col) && !visited[curr.Row - 1, curr.Col]) // north
            {
                stack.Push(new Pos(curr.Row - 1, curr.Col));
            }

            if (CanVisit(curr.Row + 1, curr.Col) && !visited[curr.Row + 1, curr.Col]) // south
            {
                stack.Push(new Pos(curr.Row + 1, curr.Col));
            }
        }

        return false;

        bool CanVisit(int col, int row)
        {
            return (col >= 0 && col < n && row >= 0 && row < n) && splitted[row][col] == '.';
        }
    }
}

public struct Pos
{
    public int Row { get; set; }

    public int Col { get; set; }

    public Pos(int row, int col)
    {
        Row = row;
        Col = col;
    }
}
