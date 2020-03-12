// 1. declaration des variables 


        let gulp                 = require('gulp');
        let sass                 = require('gulp-sass');
        let rename               = require('gulp-rename');
        const autoprefixer       = require('gulp-autoprefixer');


// 2. Mes taches 


        gulp.task('sassification', function () {
            return gulp.src('./dev/css/**/*.scss')

            // transforme le fichier css en css.min (avec commentaires)
            .pipe(sass({outputStyle:'compressed'}).on('error', sass.logError))

            // adapte le code pour augmenter un maximum la compatibilité pour les navigateurs
            .pipe(autoprefixer({cascade:false}))

            // change le nom du fichier css créé par style.min.css 
            .pipe(rename(function (path) {
                path.basename += '.min';
            }))

            // indique la destination du fichier css
            .pipe(gulp.dest('prod/css'));
            });





// 3. execution des taches 


        // lance la tâche la première fois et à chaque fois qu'un "ctrl s" est effectué dans les sous fichiers dev !
        gulp.task('observe', gulp.parallel('sassification', function() {
            gulp.watch('dev/css/**/*.scss', gulp.series('sassification'));
        }));

        // permet de taper "gulp" dans le terminal au lieu de "gulp observe"
        gulp.task('default', gulp.series('observe'));