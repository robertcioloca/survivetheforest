const config = {
    type: Phaser.AUTO,
    width: 800,
    height: 600,
    parent: 'game-container',
    scene: {
        preload: preload,
        create: create,
        update: update,
    },
};

let player;
let stars;
let bombs;
let platforms;
let cursors;
let score = 0;
let gameOver = false;
let scoreText;

function preload() {
    this.load.image('test', '/assets/test.png');
}

function create() {
    this.add.image(0, 0, 'test');
}

function update() {
}

window.initGame = () => {
    const container = document.getElementById('game-container');
    if (!container) {
        return;
    }
    if (window.phaserGame) {
        return;
    }
    try {
        window.phaserGame = new Phaser.Game(config);
    } catch (err) {
        console.err(err);
    }
};
