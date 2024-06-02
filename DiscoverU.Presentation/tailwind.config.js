module.exports = {
    content: [
        "./**/*.{razor,html,cshtml}",
    ],
    theme: {
        extend: {
            keyframes: {
                fadeIn: {
                    '0%': { opacity: 0, transform: 'translateY(20px)' },
                    '100%': { opacity: 1, transform: 'translateY(0)' }
                },
                rotateShape: {
                    '0%': { transform: 'rotate(0deg)' },
                    '100%': { transform: 'rotate(360deg)' }
                }
            },
            animation: {
                fadeIn: 'fadeIn 2s ease-out',
                rotateShape: 'rotateShape 2s linear infinite'
            }
        },
    },
    plugins: [
        require('daisyui'),
    ],
    daisyui: {
        themes: ["cupcake"],
    },
}
