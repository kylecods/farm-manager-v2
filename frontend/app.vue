<template>
  <div class="h-screen w-screen flex">
    <FSideBar :show-side="true" />

    <div class="w-full h-full bg-gray-100 text-black">
      <div class="flex justify-between items-center w-full px-3 shadow-sm z-10 h-[50px] bg-gray-200">
        <div class="cursor-pointer w-[30px]">
          <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-menu-2" width="24" height="24"
            viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round"
            stroke-linejoin="round">
            <path stroke="none" d="M0 0h24v24H0z" fill="none"></path>
            <path d="M4 6l16 0"></path>
            <path d="M4 12l16 0"></path>
            <path d="M4 18l16 0"></path>
          </svg>
        </div>

        <div class="flex items-center justify-start space-x-3 pr-2 cursor-pointer">
          <img class="w-10 h-10 rounded-full border-2 border-black-50" src="../../assets/logo.svg" alt="">
          <div class="font-semibold text-left">
            <div>Guest</div>
            <div class="text-xs">Admin</div>
          </div>
        </div>


      </div>
      <div class="h-[calc(100vh-50px)]">
        <NuxtPage />
      </div>
    </div>

  </div>
</template>
