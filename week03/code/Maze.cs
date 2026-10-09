public class Maze
{
    private Dictionary<(int x, int y), bool[]> _maze;
    private int _posX = 1, _posY = 1;

    public Maze(Dictionary<(int x, int y), bool[]> mazeMap)
    {
        _maze = mazeMap;
    }

    public void MoveLeft()
    {
        if (!_maze[(_posX, _posY)][0])
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _posX -= 1;
    }

    public void MoveRight()
    {
        if (!_maze[(_posX, _posY)][1])
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _posX += 1;
    }

    public void MoveUp()
    {
        if (!_maze[(_posX, _posY)][2])
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _posY -= 1;
    }

    public void MoveDown()
    {
        if (!_maze[(_posX, _posY)][3])
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _posY += 1;
    }

    public string GetStatus()
    {
        return $"Current location (x={_posX}, y={_posY})";
    }
}
