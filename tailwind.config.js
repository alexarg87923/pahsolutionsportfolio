/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./Views/**/*.{html,js,cshtml}", "./**/*.html"],
  theme: {
    extend: {},
  },
  plugins: [
    require('daisyui'),
  ],
  daisyui: {
    themes: ["dim"], 
  },
}

