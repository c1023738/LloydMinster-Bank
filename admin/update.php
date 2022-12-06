<?php
// Include config file
require_once "config.php";
 
// Define variables and initialize with empty values
$firstname = $lastname = $email = $currentaccountbalance = $simplebalance = $longtermbalance = $address = $salary = $age = "";
$firstname_err = $lastname_err = $email_err = $currentaccountbalance_err = $simplebalance_err = $longtermbalance_err = $address_err = $salary_err = $age_err = "";

// Processing form data when form is submitted
if(isset($_POST["id"]) && !empty($_POST["id"])){
    // Get hidden input value
    $id = $_POST["id"];
    
   

// Processing form data when form is submitted

    // Validate name
    $input_firstname = trim($_POST["firstname"]);
    if(empty($input_firstname)){
        $firstname_err = "Please enter a first name.";
    } elseif(!filter_var($input_firstname, FILTER_VALIDATE_REGEXP, array("options"=>array("regexp"=>"/^[a-zA-Z\s]+$/")))){
        $firstname_err = "Please enter a valid name.";
    } else{
        $firstname = $input_firstname;
    }
    
    
        // Validate name
        $input_lastname = trim($_POST["lastname"]);
        if(empty($input_lastname)){
            $lastname_err = "Please enter a last name.";
        } elseif(!filter_var($input_lastname, FILTER_VALIDATE_REGEXP, array("options"=>array("regexp"=>"/^[a-zA-Z\s]+$/")))){
            $lastname_err = "Please enter a valid name.";
        } else{
            $lastname = $input_lastname;
        }

        $input_email = trim($_POST["email"]);
        if(empty($input_email)){
            $email_err = "Please enter an email.";     
        } else{
            $email = $input_email;
        }

        $input_currentaccountbalance = trim($_POST["currentaccountbalance"]);
        if(empty($input_currentaccountbalance)){
            $currentaccountbalance_err = "Please enter the Current Account Balance.";     
        } elseif(!ctype_digit($input_currentaccountbalance)){
            $currenaccountbalance_err = "Please enter a positive integer value.";
        } else{
            $currentaccountbalance = $input_currentaccountbalance;
        }
    
        $input_simplebalance = trim($_POST["simplebalance"]);
        if(empty($input_simplebalance)){
            $simplebalance_err = "Please enter the Simple Account Balance.";     
        } elseif(!ctype_digit($input_simplebalance)){
            $simplebalance_err = "Please enter a positive integer value.";
        } else{
            $simplebalance = $input_simplebalance;
        }
    
        $input_longtermbalance = trim($_POST["longtermbalance"]);
        if(empty($input_longtermbalance)){
            $longtermbalance_err = "Please enter the Long-Term Account Balance.";     
        } elseif(!ctype_digit($input_longtermbalance)){
            $longtermbalance_err = "Please enter a positive integer value.";
        } else{
            $longtermbalance = $input_longtermbalance;
        }
    // Validate address
    $input_address = trim($_POST["address"]);
    if(empty($input_address)){
        $address_err = "Please enter an address.";     
    } else{
        $address = $input_address;
    }
    
    // Validate salary
    $input_salary = trim($_POST["salary"]);
    if(empty($input_salary)){
        $salary_err = "Please enter the salary amount.";     
    } elseif(!ctype_digit($input_salary)){
        $salary_err = "Please enter a positive integer value.";
    } else{
        $salary = $input_salary;
    }
    
    $input_age = trim($_POST["age"]);
    if(empty($input_age)){
        $age_err = "Please enter the age.";     
    } elseif(!ctype_digit($input_age)){
        $age_err = "Please enter a positive integer value.";
    } else{
        $age = $input_age;
    }
    // Check input errors before inserting in database
    if(empty($firstname_err) && empty($lastname_err) && empty($currentaccountbalance_err) && empty($simplebalance_err) && empty($longtermbalance_err) && empty($address_err) && empty($salary_err) && empty($age_err)){
        // Prepare an insert statement
        $sql = "INSERT INTO customers (firstname, lastname, email, currentaccountbalance, simplebalance, longtermbalance, salary, age, address) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
  
        if($stmt = mysqli_prepare($link, $sql)){
            // Bind variables to the prepared statement as parameters
            mysqli_stmt_bind_param($stmt, "sssssssss", $param_firstname, $param_lastname, $param_email, $param_currentaccountbalance, $param_simplebalance, $param_longtermbalance, $param_salary, $param_age, $param_address );
            
            // Set parameters
            $param_firstname = $firstname;
            $param_lastname = $lastname;
            $param_email = $email;
            $param_currentaccountbalance = $currentaccountbalance;
            $param_simplebalance = $simplebalance;
            $param_longtermbalance = $longtermbalance;
            $param_salary = $salary;
            $param_age = $age;
            $param_address = $address;
            
            // Attempt to execute the prepared statement
            if(mysqli_stmt_execute($stmt)){
                // Records updated successfully. Redirect to landing page
                header("location: index.php");
                exit();
            } else{
                echo "Oops! Something went wrong. Please try again later.";
            }
            mysqli_stmt_close($stmt);
        }
    
         
        // Close statement
        
    }
    
    // Close connection
    mysqli_close($link);
} else{
    // Check existence of id parameter before processing further
    if(isset($_GET["id"]) && !empty(trim($_GET["id"]))){
        // Get URL parameter
        $id =  trim($_GET["id"]);
        
        // Prepare a select statement
        $sql = "SELECT * FROM employees WHERE id = ?";
        if($stmt = mysqli_prepare($link, $sql)){
            // Bind variables to the prepared statement as parameters
            mysqli_stmt_bind_param($stmt, "i", $param_id);
            
            // Set parameters
            $param_id = $id;
            
            // Attempt to execute the prepared statement
            if(mysqli_stmt_execute($stmt)){
                $result = mysqli_stmt_get_result($stmt);
    
                if(mysqli_num_rows($result) == 1){
                    /* Fetch result row as an associative array. Since the result set
                    contains only one row, we don't need to use while loop */
                    $row = mysqli_fetch_array($result, MYSQLI_ASSOC);
                    
                    // Retrieve individual field value
                    $firstname = $row["firstname"];
                    $lastname = $row["lastname"];
                    $email = $row["email"];
                    $accountbalance = $row["accountbalance"];
                    $address = $row["address"];
                    $salary = $row["salary"];
                    $age = $row["age"];

                } else{
                    // URL doesn't contain valid id. Redirect to error page
                    header("location: error.php");
                    exit();
                }
                
            } else{
                echo "Oops! Something went wrong. Please try again later.";
            }
             mysqli_stmt_close($stmt);
        }
        
        // Close statement
       
        
        // Close connection
        mysqli_close($link);
    }  else{
        // URL doesn't contain id parameter. Redirect to error page
        header("location: error.php");
        exit();
    }
}
?>
 
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Update Record</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <style>
        .wrapper{
            width: 600px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <div class="wrapper">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <h2 class="mt-5">Update Record</h2>
                    <p>Please edit the input values and submit to update the customer record.</p>
                    <form action="<?php echo htmlspecialchars(basename($_SERVER['REQUEST_URI'])); ?>" method="post">
                        <div class="form-group">
                            <label>First Name</label>
                            <input type="text" name="firstname" class="form-control <?php echo (!empty($name_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $firstname; ?>">
                            <span class="invalid-feedback"><?php echo $firstname_err;?></span>
                        </div>
                        <div class="form-group">
                            <label>Last Name</label>
                            <input type="text" name="lastname" class="form-control <?php echo (!empty($lastname_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $lastname; ?>">
                            <span class="invalid-feedback"><?php echo $lastname_err;?></span>
                        </div>
                        <div class="form-group">
                            <label>Email</label>
                            <input type="email" name="email" class="form-control <?php echo (!empty($email_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $email; ?>">
                            <span class="invalid-feedback"><?php echo $email_err;?></span>
                        </div>
                        <div class="form-group">
                            <label>Current Account Balance</label>
                            <input type="text" name="currentaccountbalance" class="form-control <?php echo (!empty($currentaccountbalance_err)) ? 'is-invalid' : ''; ?>"value="<?php echo $currentaccountbalance; ?>">
                            <span class="invalid-feedback"><?php echo $currentaccountbalance_err;?></span>
                        </div>
                        <div class="form-group">
                            <label>Simple Account Balance</label>
                            <input type="text" name="simplebalance" class="form-control <?php echo (!empty($simplebalance_err)) ? 'is-invalid' : ''; ?>"value="<?php echo $simplebalance; ?>">
                            <span class="invalid-feedback"><?php echo $simplebalance_err;?></span>
                        </div>
                        <div class="form-group">
                            <label>Long-Term Account Balance</label>
                            <input type="text" name="longtermbalance" class="form-control <?php echo (!empty($longtermbalance_err)) ? 'is-invalid' : ''; ?>"value="<?php echo $longtermbalance; ?>">
                            <span class="invalid-feedback"><?php echo $longtermbalance_err;?></span>
                        </div>
                        <div class="form-group">
                            <label>Salary</label>
                            <input type="text" name="salary" class="form-control <?php echo (!empty($salary_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $salary; ?>">
                            <span class="invalid-feedback"><?php echo $salary_err;?></span>
                        </div>
                        <div class="form-group">
                            <label>Age</label>
                            <input type="text" name="age" class="form-control <?php echo (!empty($age_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $age; ?>">
                            <span class="invalid-feedback"><?php echo $age_err;?></span>
                        </div>
                        <div class="form-group">
                            <label>Address</label>
                            <input type="text" name="address" class="form-control <?php echo (!empty($address_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $address; ?>">
                            <span class="invalid-feedback"><?php echo $address_err;?></span>
                        </div>
                        <input type="hidden" name="id" value="<?php echo $id; ?>"/>
                        <input type="submit" class="btn btn-primary" value="Submit">
                        <a href="index.php" class="btn btn-secondary ml-2">Cancel</a>
                    </form>
                </div>
            </div>        
        </div>
    </div>
</body>
</html>