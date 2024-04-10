/** @type {import('tailwindcss').Config} */
import typography from '@tailwindcss/typography';
import forms from '@tailwindcss/forms';
import aspectRatio from '@tailwindcss/aspect-ratio';
//import postcss-nesting from 'postcss-nesting';


/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./index.html",
    "./src/**/*.{vue,js,ts,jsx,tsx}",
  ],
  theme: {
    extend: {},
  },
  // plugins: {
  //   "postcss-import": {},
  //   "tailwindcss/nesting": {},
  //   tailwindcss: {},
  //   autoprefixer: {},
  // }
  plugins: [
    typography,
    forms,
    aspectRatio
    
  ],
}
