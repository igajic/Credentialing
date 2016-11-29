//load dependecies
var gulp             = require('gulp'),
	autoprefixer     = require('autoprefixer'),
	notify           = require('gulp-notify'),
	plumber          = require('gulp-plumber'),
	postcss          = require('gulp-postcss'),
	sass             = require('gulp-sass'),
	sourcemaps       = require('gulp-sourcemaps'),
	svgmin           = require('gulp-svgmin');
	gutil            = require('gulp-util'),
	path             = require('path'),
	flexBugsFix      = require('postcss-flexbugs-fixes');

var notifySVGOMG = {
	title: 'Awesome!',
	message: 'SVG files are optimized!',
	icon: path.join(__dirname, 'assets/img/logo.jpg'),
	time: 1500,
	sound: true
};

var notifyStyles = {
	title: 'Good job :)',
	message: 'Styles are compiled!',
	icon: path.join(__dirname, 'assets/img/logo.jpg'),
	time: 1500,
	sound: true
};

//error notification settings for plumber
var plumberErrorHandler = {
	errorHandler: notify.onError({
		title: 'There was some Error, I think...',
		message: "Error message: <%= error.message %>"
	})
};

// SVG optimization
gulp.task('svgomg', function () {
	return gulp.src('img/svg/*.svg')
		.pipe(svgmin({
			plugins: [
				{ removeTitle: true },
				{ removeRasterImages: true },
				{ sortAttrs: true }
				//{ removeStyleElement: true }
			]
		}))
		.pipe(gulp.dest('img/svg'));
		//.pipe(notify(notifySVGOMG));
});

//styles
gulp.task('styles', function() {
	var processors = [
		autoprefixer({ browsers: ['last 3 versions', 'ios >= 6'] }),
		flexBugsFix
	];
	return gulp.src(['scss/**/*.scss'])
		.pipe(plumber(plumberErrorHandler))
		.pipe(sourcemaps.init())
		.pipe(sass({outputStyle: 'compressed'}))
		.pipe(postcss(processors))
		.pipe(sourcemaps.write('.'))
		.pipe(gulp.dest('css'));
		//.pipe(notify(notifySVG)); // uncomment this line if you want to see notifications when CSS is compiled
});

//watch
gulp.task('default', function() {
	//watch .scss files
	gulp.watch('scss/**/*.scss', ['styles']);
	//watch added or changed svg files to optimize them
	gulp.watch('img/svg/*.svg', ['svgomg']);
});
