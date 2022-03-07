

def nothing = "nothing"



node
{
    parameters {
    string(name: 'paramA', defaultValue: 'Hello', description: 'How should I greet the world?')
}

    stage ('Cyka'){
        input message: 'hello', ok: 'Aga'
    }

    stage('Hello')
    {
        echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
    }

    stage('Build'){
        echo "Building ${params.paramA}"
    }

    
}