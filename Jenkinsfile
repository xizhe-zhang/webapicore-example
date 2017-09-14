node {
   stage('Clear Working Directory') { // for display purposes
        sh 'sudo rm -r -f webapiapp/*'
		deleteDir()
   }
   stage('Copy Source Code') { // for display purposes
		sh 'cp -r ../API_SEOM_XML@script/webapiapp/ .'
   } 
   stage('Build dotnet') {
        dir('webapiapp') {
            sh 'sudo dotnet restore'
            sh 'sudo dotnet build'
        }
   }
   stage('Do deploy') {
        sh 'sudo rm -r -f /opt/p8/webapiapp/netcoreapp2.0/*'
        sh 'sudo supervisorctl stop PhotoGalleryP8'
        sh 'sudo cp -r webapiapp/bin/Debug/netcoreapp2.0/* /opt/p8/webapiapp/bin/Debug/netcoreapp2.0'
        sh 'sudo supervisorctl start PhotoGalleryP8'    
   }
}