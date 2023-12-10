import { 
    defineConfig, 
    presetIcons,
    presetTypography,
    presetUno
} from 'unocss'

export default defineConfig({
    shortcuts: {
        'resize-svg': 'w-15 h-15',
    },
    presets: [
        presetUno({
          attributifyPseudo: true,
        }),
        presetIcons({
          scale: 1.2,
          extraProperties: {
            'color': 'inherit',
            // Avoid crushing of icons in crowded situations
            'min-width': '1.2em',
          },
        }),
        presetTypography()
      ],
})