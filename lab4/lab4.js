(function (lib, img, cjs, ss, an) {

var p; // shortcut to reference prototypes
lib.webFontTxtInst = {}; 
var loadedTypekitCount = 0;
var loadedGoogleCount = 0;
var gFontsUpdateCacheList = [];
var tFontsUpdateCacheList = [];
lib.ssMetadata = [
		{name:"lab4_atlas_", frames: [[617,1526,550,263],[0,1526,615,410],[0,0,2032,1524]]}
];



lib.updateListCache = function (cacheList) {		
	for(var i = 0; i < cacheList.length; i++) {		
		if(cacheList[i].cacheCanvas)		
			cacheList[i].updateCache();		
	}		
};		

lib.addElementsToCache = function (textInst, cacheList) {		
	var cur = textInst;		
	while(cur != exportRoot) {		
		if(cacheList.indexOf(cur) != -1)		
			break;		
		cur = cur.parent;		
	}		
	if(cur != exportRoot) {		
		var cur2 = textInst;		
		var index = cacheList.indexOf(cur);		
		while(cur2 != cur) {		
			cacheList.splice(index, 0, cur2);		
			cur2 = cur2.parent;		
			index++;		
		}		
	}		
	else {		
		cur = textInst;		
		while(cur != exportRoot) {		
			cacheList.push(cur);		
			cur = cur.parent;		
		}		
	}		
};		

lib.gfontAvailable = function(family, totalGoogleCount) {		
	lib.properties.webfonts[family] = true;		
	var txtInst = lib.webFontTxtInst && lib.webFontTxtInst[family] || [];		
	for(var f = 0; f < txtInst.length; ++f)		
		lib.addElementsToCache(txtInst[f], gFontsUpdateCacheList);		

	loadedGoogleCount++;		
	if(loadedGoogleCount == totalGoogleCount) {		
		lib.updateListCache(gFontsUpdateCacheList);		
	}		
};		

lib.tfontAvailable = function(family, totalTypekitCount) {		
	lib.properties.webfonts[family] = true;		
	var txtInst = lib.webFontTxtInst && lib.webFontTxtInst[family] || [];		
	for(var f = 0; f < txtInst.length; ++f)		
		lib.addElementsToCache(txtInst[f], tFontsUpdateCacheList);		

	loadedTypekitCount++;		
	if(loadedTypekitCount == totalTypekitCount) {		
		lib.updateListCache(tFontsUpdateCacheList);		
	}		
};
// symbols:



(lib.plane = function() {
	this.spriteSheet = ss["lab4_atlas_"];
	this.gotoAndStop(0);
}).prototype = p = new cjs.Sprite();



(lib.skyjpgкопия = function() {
	this.spriteSheet = ss["lab4_atlas_"];
	this.gotoAndStop(1);
}).prototype = p = new cjs.Sprite();



(lib.Sky_18 = function() {
	this.spriteSheet = ss["lab4_atlas_"];
	this.gotoAndStop(2);
}).prototype = p = new cjs.Sprite();
// helper functions:

function mc_symbol_clone() {
	var clone = this._cloneProps(new this.constructor(this.mode, this.startPosition, this.loop));
	clone.gotoAndStop(this.currentFrame);
	clone.paused = this.paused;
	clone.framerate = this.framerate;
	return clone;
}

function getMCSymbolPrototype(symbol, nominalBounds, frameBounds) {
	var prototype = cjs.extend(symbol, cjs.MovieClip);
	prototype.clone = mc_symbol_clone;
	prototype.nominalBounds = nominalBounds;
	prototype.frameBounds = frameBounds;
	return prototype;
	}


(lib.Tween1 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Layer 1
	this.instance = new lib.plane();
	this.instance.parent = this;
	this.instance.setTransform(-59,36.5,0.545,0.5,0,180,0);

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(-59,-95,300,131.5);


(lib.Symbol5 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{});

	// Layer 1
	this.shape = new cjs.Shape();
	this.shape.graphics.f("#FFFFFF").s().p("AgMBKIAAAAIAAANIgdAAIAAg8IAdAAQABAjANAAQAKAAAAgPQAAgNgGgHQgFgGgNgLQgQgMgHgMQgIgNABgQQgBgTAKgNQAJgNANAAQANAAAIAPIABAAIAAgNIAcAAIAAA5IgcAAQgBgTgCgHQgDgGgGAAQgLAAAAAOQAAALAFAGQAFAHAMAJQASAOAIALQAIANAAATQAAAUgKANQgKANgNAAQgNAAgKgPg");
	this.shape.setTransform(219.8,25.3);

	this.shape_1 = new cjs.Shape();
	this.shape_1.graphics.f("#FFFFFF").s().p("AgMBnQgIgKAAgYIAAhmIgQAAIAAgcIAQAAIAAgdQAQgKAOgNIAAA0IAVAAIAAAcIgVAAIAABmQAAARAOAAQAFAAAIgDIAAAbQgLAEgOAAQgRAAgHgLg");
	this.shape_1.setTransform(210.2,22.8);

	this.shape_2 = new cjs.Shape();
	this.shape_2.graphics.f("#FFFFFF").s().p("AgvB1IAAgcIAcAAIAIgiIgoiPIgNAAIAAgcIA6AAIAAAcIgOAAIAWBdIABAAIAVhdIgNAAIAAgcIA2AAIAAAcIgMAAIgzDNg");
	this.shape_2.setTransform(199.1,28.2);

	this.shape_3 = new cjs.Shape();
	this.shape_3.graphics.f("#FFFFFF").s().p("AANB9IAAiCQAAgTgLABQgFgBgJAJIAABvIAMAAIAAAdIg4AAIAAgdIANAAIAAi/IgNAAIAAgdIAsAAIAABTQAMgMAMAAQAgAAAAAyIAABjIANAAIAAAdg");
	this.shape_3.setTransform(187.2,21.5);

	this.shape_4 = new cjs.Shape();
	this.shape_4.graphics.f("#FFFFFF").s().p("AgjBGQgLgVAAgxQAAgvAKgVQAJgVAVAAQAQAAAIAQIABAAIAAgOIAcAAIAAA/IgcAAQAAgVgEgJQgEgIgJAAQgJAAgDALQgEALAAAbIAAAaQAAAbAFALQAEALAHAAQAKAAAEgJQAEgIAAgWIAbAMQAAAagMAPQgMAOgVAAQgZAAgMgUg");
	this.shape_4.setTransform(175,25.4);

	this.shape_5 = new cjs.Shape();
	this.shape_5.graphics.f("#FFFFFF").s().p("AgtBoQgKgXAAgpQAAgyAJgWQAJgVAVgBQAPABAKAPIABAAIAAg6IgTAAIAAgdIAzAAIAADcIAOAAIAAAdIguAAIAAgSIgBAAQgFAKgEAFQgGAFgKAAQgTAAgKgWgAgTgPQgDAMAAAcIAAAoQAAAgAQAAQAKAAADgLQADgLAAgiIAAgcQAAgUgEgJQgEgKgIAAQgKAAgDALg");
	this.shape_5.setTransform(162.8,21.6);

	this.shape_6 = new cjs.Shape();
	this.shape_6.graphics.f("#FFFFFF").s().p("AgiBGQgMgWAAguQAAguAMgXQALgXAYAAQAUAAANATQANASAAAkIAAAaIg8AAIAAAHQAAAYAEALQADAMAIAAQAOAAADgcIAbAKQgFAWgMAMQgMAMgQAAQgYAAgLgVgAgKg1QgDAJAAAVIAAAIIAdAAIAAgPQAAghgPAAQgIAAgDAKg");
	this.shape_6.setTransform(150.5,25.3);

	this.shape_7 = new cjs.Shape();
	this.shape_7.graphics.f("#FFFFFF").s().p("AAdB9IgdhyIgOABIAABTIARAAIAAAeIhKAAIAAgeIAVAAIAAi9IgVAAIAAgeIA/AAQAfAAASATQASASAAAeQAAAogdATIAbBdIAPAAIAAAegAgOgSQATAAAJgJQAIgJAAgVQAAgVgIgHQgJgJgTAAg");
	this.shape_7.setTransform(137.1,21.5);

	this.shape_8 = new cjs.Shape();
	this.shape_8.graphics.f("#FFFFFF").s().p("AAqBYIAAh/QAAgLgCgEQgCgEgGAAQgHAAgEAFQgFAFAAACIAABpIANAAIAAAdIgrAAIAAh/QAAgKgDgFQgCgEgGAAQgIAAgIAMIAABpIANAAIAAAdIg5AAIAAgdIANAAIAAhzIgNAAIAAgdIAsAAIAAAPIABAAQALgRAQAAQAPAAAJARQAMgRARAAQAhAAAAAvIAABjIANAAIAAAdg");
	this.shape_8.setTransform(108.7,25.2);

	this.shape_9 = new cjs.Shape();
	this.shape_9.graphics.f("#FFFFFF").s().p("AgiBGQgMgWAAguQAAguAMgXQALgXAYAAQAUAAANATQANASAAAkIAAAaIg8AAIAAAHQAAAYAEALQADAMAIAAQAOAAADgcIAbAKQgFAWgMAMQgMAMgQAAQgYAAgLgVgAgKg1QgDAJAAAVIAAAIIAdAAIAAgPQAAghgPAAQgIAAgDAKg");
	this.shape_9.setTransform(93.5,25.3);

	this.shape_10 = new cjs.Shape();
	this.shape_10.graphics.f("#FFFFFF").s().p("AgMBnQgIgKAAgYIAAhmIgPAAIAAgcIAPAAIAAgdQAQgKAOgNIAAA0IAVAAIAAAcIgVAAIAABmQAAARAOAAQAFAAAHgDIAAAbQgKAEgOAAQgQAAgIgLg");
	this.shape_10.setTransform(83.3,22.8);

	this.shape_11 = new cjs.Shape();
	this.shape_11.graphics.f("#FFFFFF").s().p("AgrBYIAAgdIAPAAIAAhzIgPAAIAAgdIAuAAIAAAiIABAAQAIgWAJgHQAHgHAQAAIAAAhQgpAAAAAvIAABCIASAAIAAAdg");
	this.shape_11.setTransform(73.7,25.2);

	this.shape_12 = new cjs.Shape();
	this.shape_12.graphics.f("#FFFFFF").s().p("AAFB9IAAgeIAQAAIgGg5IgdAAIgGA5IAPAAIAAAeIhCAAIAAgeIAPAAIAci9IgSAAIAAgeIBcAAIAAAeIgRAAIAcC9IAPAAIAAAegAgMAIIAYAAIgKhvIgDAAg");
	this.shape_12.setTransform(60.9,21.5);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.shape_12},{t:this.shape_11},{t:this.shape_10},{t:this.shape_9},{t:this.shape_8},{t:this.shape_7},{t:this.shape_6},{t:this.shape_5},{t:this.shape_4},{t:this.shape_3},{t:this.shape_2},{t:this.shape_1},{t:this.shape}]}).wait(1));

}).prototype = getMCSymbolPrototype(lib.Symbol5, new cjs.Rectangle(0,0,278.3,44), null);


// stage content:
(lib.lab4 = function(mode,startPosition,loop) {
	this.initialize(mode,startPosition,loop,{audio:0});

	// timeline functions:
	this.frame_0 = function() {
		this.GotoStartButton.addEventListener("click", fl_ClickToGoToAndPlayFromFrame.bind(this));
		
		function fl_ClickToGoToAndPlayFromFrame()
		{
			this.gotoAndPlay(0);
					createjs.Sound.setMute(false);
		}
		
		this.stopbutton.addEventListener("click", fl_ClickStopFrame.bind(this));
		
		function fl_ClickStopFrame()
		{
			this.stop();
			//createjs.Sound.stop();
				createjs.Sound.setMute(true);
		}
		
		this.playbutton.addEventListener("click", fl_ClickStartFrame.bind(this));
		
		function fl_ClickStartFrame()
		{
			this.play();
				createjs.Sound.setMute(false);
		}
	}

	// actions tween:
	this.timeline.addTween(cjs.Tween.get(this).call(this.frame_0).wait(100));

	// Layer 9
	this.instance = new lib.Symbol5();
	this.instance.parent = this;
	this.instance.setTransform(-73.4,36.6,0.455,0.455,0,0,0,142.6,43.1);
	this.instance.alpha = 0;

	this.timeline.addTween(cjs.Tween.get(this.instance).wait(1).to({regX:138.9,regY:24.4,x:-65.5,y:28,alpha:0.137},0).wait(1).to({x:-56.1,alpha:0.254},0).wait(1).to({x:-46.6,alpha:0.356},0).wait(1).to({x:-37.1,alpha:0.448},0).wait(1).to({x:-27.7,alpha:0.529},0).wait(1).to({x:-18.2,alpha:0.602},0).wait(1).to({x:-8.7,alpha:0.667},0).wait(1).to({x:0.7,alpha:0.723},0).wait(1).to({x:10.2,alpha:0.773},0).wait(1).to({x:19.7,alpha:0.816},0).wait(1).to({x:29.1,alpha:0.853},0).wait(1).to({x:38.6,alpha:0.883},0).wait(1).to({x:48.1,alpha:0.908},0).wait(1).to({x:57.5,alpha:0.927},0).wait(1).to({x:66.9,alpha:0.94},0).wait(1).to({x:71.4,y:29.4,alpha:0.948},0).wait(1).to({x:75.9,y:30.7,alpha:0.95},0).wait(1).to({x:80.4,y:32},0).wait(1).to({x:84.9,y:33.3},0).wait(1).to({x:89.4,y:34.6},0).wait(1).to({x:93.9,y:35.9},0).wait(1).to({x:90.3,y:35.1},0).wait(1).to({x:86.6,y:34.2},0).wait(1).to({x:82.9,y:33.3},0).wait(1).to({x:79.2,y:32.4},0).wait(1).to({x:75.6,y:31.5},0).wait(1).to({x:71.9,y:30.7},0).wait(1).to({x:68.2,y:29.8},0).wait(1).to({x:64.5,y:28.9},0).wait(1).to({x:60.9,y:28},0).wait(1).to({x:57.2,y:27.1},0).wait(1).to({x:67.6,y:34.3},0).wait(1).to({x:78,y:41.4},0).wait(1).to({x:88.4,y:48.6},0).wait(1).to({x:98.8,y:55.7},0).wait(1).to({x:109.2,y:62.9},0).wait(1).to({x:119.6,y:70},0).wait(1).to({x:130,y:77.2},0).wait(1).to({x:140.4,y:84.3},0).wait(1).to({x:150.8,y:91.5},0).wait(1).to({x:161.1,y:98.6},0).wait(1).to({x:145.1,y:95.1},0).wait(1).to({x:129,y:91.6},0).wait(1).to({x:112.9,y:88.1},0).wait(1).to({x:96.8,y:84.5},0).wait(1).to({scaleX:0.49,scaleY:0.48,x:116.6,y:80.5},0).wait(1).to({scaleX:0.52,scaleY:0.51,x:136.4,y:76.4},0).wait(1).to({scaleX:0.55,scaleY:0.54,x:156.1,y:72.3},0).wait(1).to({scaleX:0.59,scaleY:0.57,x:175.9,y:68.2},0).wait(1).to({scaleX:0.62,scaleY:0.6,x:195.7,y:64.1},0).wait(1).to({scaleX:0.65,scaleY:0.63,x:215.4,y:60.1},0).wait(1).to({scaleX:0.69,scaleY:0.66,x:235.2,y:56},0).wait(1).to({scaleX:0.72,scaleY:0.68,x:255,y:51.8},0).wait(1).to({scaleX:0.75,scaleY:0.71,x:274.7,y:47.8},0).wait(1).to({scaleX:0.79,scaleY:0.74,x:274.6,y:47.2},0).wait(1).to({scaleX:0.82,scaleY:0.77,x:274.5,y:46.7},0).wait(1).to({scaleX:0.85,scaleY:0.8,x:274.3,y:46.2},0).wait(1).to({scaleX:0.88,scaleY:0.83,x:274.2,y:45.6},0).wait(1).to({scaleX:0.9,scaleY:0.83},0).wait(1).to({scaleX:0.91,scaleY:0.83},0).wait(1).to({scaleX:0.92,scaleY:0.83,x:274.1},0).wait(1).to({scaleX:0.93,scaleY:0.83,y:45.5},0).wait(1).to({scaleX:0.94,scaleY:0.83,x:274},0).wait(1).to({scaleX:0.95,scaleY:0.83},0).wait(1).to({scaleX:0.96,scaleY:0.83,x:273.9},0).wait(1).to({scaleX:0.97,scaleY:0.84},0).wait(1).to({scaleX:0.98,scaleY:0.84,y:45.4},0).wait(1).to({scaleX:0.99,scaleY:0.84,x:273.8},0).wait(1).to({scaleX:1,scaleY:0.84},0).wait(1).to({scaleX:1.02,scaleY:0.84,x:273.7},0).wait(1).to({scaleX:1.03,scaleY:0.84,y:45.3},0).wait(1).to({scaleX:1.04,scaleY:0.84},0).wait(1).to({scaleX:1.05,scaleY:0.84,x:273.6},0).wait(1).to({scaleX:1.06,scaleY:0.85},0).wait(1).to({scaleX:1.07,scaleY:0.85,x:273.5},0).wait(1).to({scaleX:1.08,scaleY:0.85,y:45.2},0).wait(1).to({scaleX:1.09,scaleY:0.85,x:273.4},0).wait(1).to({scaleX:1.1,scaleY:0.85},0).wait(22));

	// Layer 5
	this.instance_1 = new lib.Tween1("synched",0);
	this.instance_1.parent = this;
	this.instance_1.setTransform(-67.5,269.1);
	this.instance_1._off = true;

	this.timeline.addTween(cjs.Tween.get(this.instance_1).wait(2).to({_off:false},0).to({regX:0.1,regY:-0.1,scaleX:0.63,scaleY:0.63,rotation:180,x:-39.3,y:258.2},1).to({regX:0,regY:0,scaleX:1,scaleY:1,rotation:0,x:81.6,y:192.6},6).to({x:109.7,y:239.8},10).to({x:196.4,y:149.3},10).to({x:202.7,y:158.5},2).to({x:228.2,y:195.2},8).to({x:288.1,y:107.2},10).to({x:325.1,y:141.7},10).to({x:414.3,y:76.7},10).to({x:453.8,y:122.6},10).to({x:545.6,y:46.1},10).to({x:628.2},6).wait(4).to({startPosition:0},0).wait(1));

	// Layer 1
	this.instance_2 = new lib.skyjpgкопия();
	this.instance_2.parent = this;
	this.instance_2.setTransform(0,-10);

	this.instance_3 = new lib.Sky_18();
	this.instance_3.parent = this;
	this.instance_3.setTransform(0,-52,0.339,0.297);

	this.timeline.addTween(cjs.Tween.get({}).to({state:[{t:this.instance_3},{t:this.instance_2}]}).wait(100));

}).prototype = p = new cjs.MovieClip();
p.nominalBounds = new cjs.Rectangle(136.7,148,826.5,452);
// library properties:
lib.properties = {
	width: 550,
	height: 400,
	fps: 24,
	color: "#FFFFFF",
	opacity: 1.00,
	webfonts: {},
	manifest: [
		{src:"images/lab4_atlas_.png", id:"lab4_atlas_"}
	],
	preloads: []
};




})(lib = lib||{}, images = images||{}, createjs = createjs||{}, ss = ss||{}, AdobeAn = AdobeAn||{});
var lib, images, createjs, ss, AdobeAn;