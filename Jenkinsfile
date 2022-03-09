

def nothing = "nothing"



node
{
    parameters {
    string(name: 'paramA', defaultValue: 'Hello', description: 'How should I greet the world?')
}

    stage ('Cyka'){
        input message: 'Production or Sandbox', parameters: [choice(choices: ['Production', 'Sandbox'], description: '', name: 'DeployTo')]
        echo "Deploying to ${params.DeployTo}"
    }

    stage('Hello')
    {
        echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
    }

    stage('Build'){
        echo "Building ${params.paramA}"
    }

    
}