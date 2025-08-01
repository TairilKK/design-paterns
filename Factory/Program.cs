﻿using Factory;

var shapeFactory = new ShapeFactory();

var circle = shapeFactory.CreateShape(ShapeType.Circle);
circle.Render();

var triangle = shapeFactory.CreateShape(ShapeType.Triangle);
triangle.Render();

var rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);
rectangle.Render();
