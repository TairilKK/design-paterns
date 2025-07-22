using Proxy;

Console.WriteLine("*** DEFAULT ***");
var youTubeService = new YouTubeService();

youTubeService.GetVideo(10);
youTubeService.GetVideo(10);

Console.WriteLine("*** PROXY ***");
var proxyYouTubeService = new ProxyYouTubeService(youTubeService);

proxyYouTubeService.GetVideo(11);
proxyYouTubeService.GetVideo(11);
