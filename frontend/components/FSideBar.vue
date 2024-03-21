<template>
    <div class="w-[260px] h-full" v-show="showSide">
        <div class="flex flex-row space-x-2 justify-start pl-4 items-center h-[50px] bg-slate-500">
            <FluentLeaf/>
            <h3 class="text-xl font-bold">
                Farm Manager
            </h3> 
            
        </div>
        <div class="h-[calc(100vh-50px)] py-4">
        <div class="px-2 flex flex-col space-y-3">
            <NuxtLink to="/" class="inline-flex relative items-center py-2 px-2 w-full text-sm font-medium rounded-md border-gray-200 hover:bg-gray-100 hover:text-gray-600 transition duration-400 ease-in-out">
                Home
            </NuxtLink>
        </div>

    </div>

    </div>

</template>

<script setup lang="ts">
    import FluentLeaf from '../components/icons/FluentLeaf.vue'
    defineProps({
        showSide: {
            type: Boolean,
            default: true
        } 
    })
</script>