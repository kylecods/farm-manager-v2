<script setup>
import {FluentLeaf} from './components/icons/FluentLeaf.vue'
const colorMode = useColorMode()
const isDark = computed({
  get() {
    return colorMode.value === 'dark'
  },
  set() {
    colorMode.preference = colorMode.value === 'dark' ? 'light' : 'dark'
  }
})

</script>

<template>
  <div class="h-screen w-screen flex">
    <div class="h-full w-full grid content-center">
      <div class="flex justify-center w-full">
         <FluentLeaf />
          <h1 class="text-4xl text-center self-center" :class="isDark ? 'text-white' : 'text-black-200'">
            Farm Manager
          </h1>
        </div>
      
      <p class="p-10 text-center" :class="isDark ? 'text-gray-400' : 'text-gray-600'">
        Welcome to Farm Manager! Click on the above links to get started 
      </p>
      <div class="w-200 justify-self-center flex justify-center">
        <UButton size="lg" class="bg" :icon="isDark ? 'i-heroicons-moon-20-solid' : 'i-heroicons-sun-20-solid'"
          variant="solid" @click="isDark = !isDark" />
      </div>
    </div>
  </div>
</template>

