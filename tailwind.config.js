/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./SurviveTheForest/**/*.razor",
        "./SurviveTheForest.Client/**/*.razor",
        "./SurviveTheForest/**/*.html",
        "./SurviveTheForest.Client/**/*.html"
    ],
    theme: {
        extend: {
            fontFamily: {
                cinzel: ['MedievalSharp', 'cursive'],
            },
        },
    },
    plugins: [],
}
