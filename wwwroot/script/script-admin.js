const tabs = document.querySelectorAll('[data-tab-target]');
const tabContents = document.querySelectorAll('[data-tab-content]');

tabs.forEach(tab => {
    tab.addEventListener('click', () => {
        tabContents.forEach(tabContent => {
            tabContent.classList.remove('active');
        })
    
        tabs.forEach(tab => {
            tab.classList.remove('tab-active');
        })

        const target = document.querySelector(tab.dataset.tabTarget)
        target.classList.add('active');
        tab.classList.add('tab-active')
    })
})