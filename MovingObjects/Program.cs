using MovingObjects;

/*
 * interface
 * vs JavaScript
 */



//var obj = new BouncingBall(15, 3, 1, 1);
var obj = new TeleportingPlus(15, 3, -1, -1);
Console.CursorVisible = false;
while (true)
{
    Console.Clear();
    obj.Show();
    obj.Move();
    Thread.Sleep(50);
}