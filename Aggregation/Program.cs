using Aggregation;

Box box = new Box();
Ball blueBall = new Ball("Blue");
Ball redBall = new Ball("Red");

box.Show();

box.Ball = blueBall;

box.Show();

box.Ball = redBall;

box.Show();
