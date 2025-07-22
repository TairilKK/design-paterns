var s1 = new Subscriber("S1");
var s2 = new Subscriber("S2");
var s3 = new Subscriber("S3");

var p = new Publisher();
p.Subscribe(s1);
p.Subscribe(s2);
p.Subscribe(s3);

p.Notify("test message");

p.Unsubscribe(s2);

p.Notify("second test message");
