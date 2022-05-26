// importer le module express
const express = require('express');
const bodyParser = require('body-parser')

// application express
const app = express();

// body parser (analyse le contenu du corps des requêtes)
app.use(bodyParser.urlencoded())
app.use(bodyParser.json())


// middleware : s'exécute à chaque requête
app.use((req, res, next) => {
    let method = req.method;
    let path = req.originalUrl;
    console.log(`${method} ${path}`);
    next()
})

require('./middlewares/liquid')(app)

// middleware, s'execute pour les requêtes dont le chemin commence par /public
// gestion des fichiers statiques
app.use('/public', express.static(__dirname + '/public'))

// import des routes (voir le fichier routes/index.js)
const router = require('./routes')
// association du router à l'app
app.use('/', router)

//test 
console.log('test')

//fonction anonyme
//démarrage du serveur
app.listen(3000, () => {
    console.log("serveur prêt (http://localhost)")
});

