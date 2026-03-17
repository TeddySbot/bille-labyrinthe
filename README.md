Parfait, voici un README prêt à **copier-coller** avec les touches telles que tu les avais mises par erreur (`SADW`) dans ton script :

---

# Labyrinth Unity Project

## Description

**Labyrinth** est un jeu Unity où le joueur contrôle une bille dans un labyrinthe. Le projet inclut :

* Menu de démarrage pour lancer la partie.
* Chronomètre pour mesurer le temps du parcours.
* Retour automatique au menu après 3 secondes une fois le labyrinthe terminé.

---

## Fonctionnalités

1. **Déplacement du joueur**

   * Contrôles actuels (problème de touches) : `S` = avant, `A` = gauche, `D` = droite, `W` = arrière.
   * Inclinaison de la bille selon les entrées du joueur.

2. **Menu de démarrage**

   * Bouton pour commencer le jeu.
   * Affiche le **score final** (temps du chrono) après la fin de la partie.

3. **Chronomètre**

   * Commence au début de la partie.
   * S’arrête lorsque le joueur atteint la fin du labyrinthe.
   * Le temps final est affiché sur le menu principal avec minutes, secondes et millisecondes.

---

## Installation

1. Cloner le dépôt :

```bash
git clone https://github.com/TON_UTILISATEUR/labyrinth.git
```

2. Ouvrir le projet avec **Unity 2023+** (ou version compatible).
3. Vérifier que tous les packages nécessaires (Navigation, TextMeshPro, etc.) sont installés via le **Package Manager**.

---

## Structure du projet

```
Labyrinth/
├─ Assets/
│  ├─ Scenes/           # Scènes : Menu, Game
│  ├─ Scripts/          # Scripts : PlayerController, Chronometre, MenuManager
│  ├─ UI/               # Canvas et éléments UI (Text, Buttons)
├─ ProjectSettings/      # Paramètres du projet Unity
├─ .gitignore            # Fichiers à ignorer
└─ README.md             # Ce fichier
```

---

## Contrôles (tel que codé actuellement)

| Action  | Touche |
| ------- | ------ |
| Avancer | S      |
| Reculer | W      |
| Gauche  | A      |
| Droite  | D      |

