FilterGraph fg = new FilterGraph();

//global flag/options
fg.AddFlag(...);
fg.AddOption(...);

var video_input = new ....;
var image_input = new ....;
var image_input2 = new ....;

//intput flag/options
video_input.AddFlag(...);
video_input.AddOption(...);

var video_filter = fb.AddVideo(video_input);
var image_filter = fb.AddImage(image_input);
var image2_filter = fb.AddImage(image_input2);

var image_scale = image_filter.Scale(scale_option);
var video_with_overlay = image_scale.OverLayOn(video_filter, overlay_option);

var image_scale2 = image2_filter.Scale(scale_option);
var video_with_overlay2 = image_scale2.OverLayOn(video_with_overlay, overlay_option);


var video_out = ???;
//output flag/options
video_out.AddFlag(...);
video_out.AddOption(...);
video_out.MapVideo(video_with_overlay);
video_out.MapAudio(video);
fg.AddOutput(video_out);

var video_out2 = ???;
video_out2.AddFlag(...);
video_out2.AddOption(...);
video_out2.MapVideo(video_with_overlay2);
video_out2.MapAudio(video);
fg.AddOutput(video_out2);