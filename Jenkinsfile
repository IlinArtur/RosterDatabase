

def nothing = "nothing"



node
{
    
    timestamps {
    // some block
    stage ('Prepare'){
        def prod_or_sandbox = input message: 'Production or Sandbox', parameters: [choice(choices: ['Production', 'Sandbox'], description: '', name: 'DeployTo')]
        echo "Deploying to ${prod_or_sandbox}"
        currentBuild.description = "${prod_or_sandbox}"
    }
    
    return

    stage('Hello')
    {
        echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
    }

    stage('Build'){
        echo "Building ${params.paramA}"
    }

    }
    
}