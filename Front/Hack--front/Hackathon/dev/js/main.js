document.addEventListener('DOMContentLoaded', function(){

    let mesDivsTask = document.querySelectorAll('.bloc--task');
    let maDropZone  = document.querySelector('.drop--zone');
    let maTaskZone  = document.querySelector('.task--container.active');
    // let maTaskZone  = document.querySelectorAll('.task--container');
    // let maDivDrop   = document.querySelector('.drop--zone')


    ///// call Ajax et création de contenu ///////////////////////////////////////

    let xhr                     = new XMLHttpRequest();
    let monApiTaskUrl           = "js/DataBase.json";

    xhr.addEventListener('readystatechange', function(event){
        if (event.currentTarget.readyState == 4 && event.currentTarget.status == 200) {

            let taskDataBaseJSON   = JSON.parse(event.currentTarget.responseText);
            console.log(taskDataBaseJSON);
            // Part : manipulation des données JSON

            let taskDataBaseArray  = taskDataBaseJSON.task ; 

            console.log(taskDataBaseArray);
            
            for (let i = 0; i < taskDataBaseArray.length; i++) {
                
                
                // récupération des données //

                let maTache                 = taskDataBaseArray[i].Name;
                let monIdTache              = taskDataBaseArray[i].Id;
                let maDeadline              = taskDataBaseArray[i].DeadLine;
                let monCreateurTache        = taskDataBaseArray[i].CreatorId;
                let monResolverTache        = taskDataBaseArray[i].ResolverId;
                let monIndiceImportance     = taskDataBaseArray[i].Priority;
                let maLocationTache         = taskDataBaseArray[i].SectorId;

                console.log(monCreateurTache);
                console.log(monResolverTache);
                console.log(maLocationTache);




                // création des éléments selon le DOM voulu // 
            
                let maDivDropTask               = document.createElement('div'); 
                    let maDivCreateDoneUser     = document.createElement('div');
                        let maDivCreateUser     = document.createElement('div'); 
                        let maDivDoneUser       = document.createElement('div'); 
                    let maDivDateInfo           = document.createElement('div'); 
                        let maDivDate           = document.createElement('div'); 
                        let maDivInfo           = document.createElement('div'); 
                    let maDivTask               = document.createElement('div');
                        let monSpanTask         = document.createElement('span'); 
            
                // chargement des éléments pour le css //
            
                    maDivDropTask.classList.add('bloc--task');
                    maDivDropTask.setAttribute('draggable', true);
                    maDivDropTask.setAttribute('id', "block--" + "2" + monIdTache);
            
                        maDivCreateDoneUser.classList.add('create-and-done-user');

                            maDivCreateUser.classList.add('create-user');
                            maDivCreateUser.textContent = monCreateurTache; 

                            maDivDoneUser.classList.add('done-user');
                            maDivDoneUser.textContent = monResolverTache; 

            
                        maDivDateInfo.classList.add('date-info');

                            maDivDate.classList.add('date');
                            maDivDate.textContent = maDeadline;

                            maDivInfo.classList.add('info');
                                        
                        maDivTask.classList.add('task');
                        maDivTask.classList.add('task--green');
                            monSpanTask.textContent = maTache;

                // placement dans le DOM //

                    let monContainerTaskActive  = document.querySelector('.task--container.active');

                monContainerTaskActive.appendChild(maDivDropTask);

                    maDivDropTask.appendChild(maDivCreateDoneUser);
                        maDivCreateDoneUser.appendChild(maDivCreateUser);
                        maDivCreateDoneUser.appendChild(maDivDoneUser);

                    maDivDropTask.appendChild(maDivDateInfo);
                        maDivDateInfo.appendChild(maDivDate);
                        maDivDateInfo.appendChild(maDivInfo);

                    maDivDropTask.appendChild(maDivTask);
                        maDivTask.appendChild(monSpanTask);

                        
            }

            // dévoiler les infos supplémentaires ////

            let mesInfoSuppTask     = document.querySelectorAll('.date-info');
            let monBlocTask         = document.querySelectorAll('.task');

            for ( let i = 0; i < mesInfoSuppTask.length; i++ ) {

                mesInfoSuppTask[i].addEventListener('click', function() {

                    monBlocTask[i].classList.toggle('zindex');

                })
        
            }




            
        }

    })


    // envoi et récupération des données 

    window.addEventListener('load', function() {
        xhr.open('GET','js/DataBase.json' , true);
        xhr.send();
    })

    ///// Drag and Drop ///////////////////////////////////////////////////////

                for (let i = 0; i < mesDivsTask.length; i++ ) {

                    mesDivsTask[i].addEventListener('dragstart', function(event) {

                        // event.target.classlist.add('discret'); // mis en grisé ???
                        event.dataTransfer.setData('data', this.id);
                    })

                    mesDivsTask[i].addEventListener('drag', function(event) {
                        mesDivsTask[i].style.opacity = "1";
                    })

                    mesDivsTask[i].addEventListener('dragend', function(event) {
                        // event.target.classList.remove('discret');
                    })

                }

                    maDropZone.addEventListener('dragenter', function(event) {
                        maDropZone.classList.add('extend');
                    })

                    maDropZone.addEventListener('dragover', function(event) {
                        event.preventDefault();
                    })

                    maDropZone.addEventListener('dragleave', function(event) {
                        maDropZone.classList.remove('extend');
                        
                    })
                    
                    //////////////
                    
                    maDropZone.addEventListener('drop', function(event) {
                        event.preventDefault();
                        
                        let data = event.dataTransfer.getData('data');
                        let dragged = document.querySelector('#' + data); 
                        event.currentTarget.appendChild(dragged);
                        // maDropZone.textContent = 'none';
                        maDropZone.classList.remove('extend');
                        // maDropZone.classList.remove('drop--info');

                    })
                    
                    ///// dans l'autre sens /////////////////////////////

                    let maNouvelleDivTask   = document.querySelector('#create-new-task-zone');

                    maNouvelleDivTask.addEventListener('dragstart', function(event) {

                        // event.target.classlist.add('discret'); // mis en grisé ???
                        event.dataTransfer.setData('data', this.id);
                    })

                    

                    maTaskZone.addEventListener('dragenter', function(event) {
                        maTaskZone.classList.add('extend');
                    })

                    maTaskZone.addEventListener('dragover', function(event) {
                        event.preventDefault();
                    })

                    maTaskZone.addEventListener('dragleave', function(event) {
                        maTaskZone.classList.remove('extend');
                        
                    })
                    
                    //////////////
                    
                    maTaskZone.addEventListener('drop', function(event) {
                        event.preventDefault();
                        
                        let data = event.dataTransfer.getData('data');
                        let dragged = document.querySelector('#' + data); 
                        event.currentTarget.appendChild(dragged);
                        // maDropZone.textContent = 'none';
                        maTaskZone.classList.remove('extend');
                        

                    })

    ///// drag and drop END /////////////////////////////////////////////////


    // let mesInfoSuppTask     = document.querySelectorAll('.date-info');
    // let monBlocTask         = document.querySelectorAll('.task');

    // for ( let i = 0; i < mesInfoSuppTask.length; i++ ) {

    //     mesInfoSuppTask[i].addEventListener('click', function() {

    //         monBlocTask[i].classList.toggle('zindex');

    //     })
        
    // }

    ///// entrer une nouvelle task ////////////////////////////////////////////

    let nouvelleTask        = document.querySelector('#create-new-task-zone');
    
    maDropZone.addEventListener('click', function(event) {
    
        if (event.target == maDropZone) {

            nouvelleTask.classList.add('create-new-task-zone');
            maDropZone.classList.remove('drop--info');
        }


    })

    ///// menu filtre ////////////////////////////////////////////////////////

    let monBoutonFiltre         = document.querySelector('.header__filtre button');
    let maDivFiltre             = document.querySelector('.div--filtre');

    monBoutonFiltre.addEventListener('click', function() {
        maDivFiltre.classList.toggle('active');
    })

    ///// menu principal ////////////////////////////////////////////////////////

    let monMenuBurger           = document.querySelector('.logo--menu');
    // let monMenuPrincipal        = document.querySelector('...')

    monMenuBurger.addEventListener('click', function(){

        monMenuPrincipal.classList.toggle('active');

    })

    

})