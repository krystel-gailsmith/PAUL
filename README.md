
# PAUL - Panier AUtonome intelLigent

PAUL est une plateforme conçue pour les épiceries. Il s'agit d'un robot capable de se déplacer de façon autonome et de prendre des items à l'aide d'un système de préhension. Grâce à ses différents capteurs, PAUL peut côtoyer les humains de façon sécuritaire et s'adapter aux différentes épiceries. 

Ce git est dédié à l'application Web qui supporte et affiche l'état du robot dans ses fonctions.
## Deployment

Pour déployer l'application dans un conteneur Docker:

Si ce n'est déjà fait, <a href="https://docs.docker.com/get-docker/">installer Docker</a>.


Pour générer le conteneur

 ```bash
  docker run -p 8080:80 --name PAUL -d gpr1me/paulwebapp
```
Votre conteneur est maintenant en fonction. Il est possible d'y accéder dans un navigateur (http://localhost:8080). Il est aussi possible d'y accéder via d'autres appareils sur le même réseau local via l'adresse IP de votre poste (ex: http://\<votreIP\>:8080).

Sur Windows
```bash
  ipconfig
```
Sur Linux
```bash
  ifconfig
```

Il est possible d'utiliser l'application Desktop de Docker pour importer l'image (https://hub.docker.com/repository/docker/gpr1me/paulwebapp) et générer un conteneur à partir de cette image.

Pour plus de détails sur la manipulation de conteneur, voir <a href="https://docs.docker.com/engine/reference/run/">la documentation officielle</a>
