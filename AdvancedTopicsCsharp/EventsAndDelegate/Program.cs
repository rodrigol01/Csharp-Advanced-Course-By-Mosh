// See https://aka.ms/new-console-template for more information

//events
//mechanism for communication between objects
//used in building Loosely Coupled Application
//Helps extending application 

//1 define a delegate
//2 define an event based on that delegate
//3 raise the event

var video = new Video(){Title = "title 1"};
var videoEncoder = new VideoEncoder(); //publisher
var mailService = new MailService(); //subscriber
var messageaService = new MessageService(); //subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageaService.OnVideoEncoded;

videoEncoder.Encode(video);